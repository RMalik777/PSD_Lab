using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtation.Controller
{
    public class AlbumController
    {
        public static List<msAlbum> getAlbumsArtistId(int artistId)
        {
            return AlbumHandler.getAlbumArtistId(artistId);
        }

        public static string insertAlbum(string albumName, string albumDescription, string albumPrice, string albumStock, FileUpload albumImage, int artistId)
        {
            if (albumName.Trim().Equals(""))
            {
                return "Album name must be filled!";
            }
            else if (albumName.Length > 50)
            {
                return "Album name must be less or equal than 50 characters!";
            }
            else if (albumDescription.Trim().Equals(""))
            {
                return "Album Description must be filled!";
            }
            else if (albumDescription.Length > 255)
            {
                return "Album description must be less or equal than 255 characters!";
            }
            else if (albumPrice.All(char.IsDigit) == false)
            {
                return "Album price must be a digit!";
            }
            else if (albumStock.All(char.IsDigit) == false)
            {
                return "Album stock must be a digit!";
            }

            int price = Convert.ToInt32(albumPrice);
            int stock = Convert.ToInt32(albumStock);

            if (price < 100000 || price > 1000000)
            {
                return "Album price must be between 100000 and 1000000!";
            }
            else if (stock <= 0)
            {
                return "Album stock must be greater than 0!";
            }

            string imagePath = "../../Assets/Album/";
            string imageUrl = imagePath + albumImage.FileName;
            string fileExtension = Path.GetExtension(albumImage.PostedFile.FileName);
            int fileSizeMB = (albumImage.PostedFile.ContentLength / 1024) / 1024;

            if (albumImage.HasFile == false)
            {
                return "File must not be empty!";
            }
            else if (!fileExtension.Equals(".png") && !fileExtension.Equals(".jpg") && !fileExtension.Equals(".jpeg") && !fileExtension.Equals(".jfif"))
            {
                return "File extension must be .png/.jpg/.jpeg/.jfif only!";
            }
            else if (albumImage.FileName.Length > 50 || albumImage.FileName.Length + imagePath.Length > 50)
            {
                return "File name is too long!";
            }
            else if (fileSizeMB > (2 / 1024) / 1024)
            {
                return "File size is too big!";
            }

            albumImage.SaveAs(HttpContext.Current.Server.MapPath(imageUrl));
            return AlbumHandler.insertAlbum(albumName, albumDescription, price, stock, imageUrl, artistId);
        }

        public static void deleteAlbum(int albumId)
        {
            msAlbum album = AlbumController.getAlbumById(albumId);
            AlbumHandler.deleteAlbum(albumId);
        }

        public static msAlbum getAlbumById(int albumId)
        {
            return AlbumHandler.getAlbumById(albumId);
        }

        public static string updateAlbum(int albumId, string albumName, string albumDescription, string albumPrice, string albumStock, FileUpload albumImage)
        {
            if (albumName.Trim().Equals(""))
            {
                return "Album name must be filled!";
            }
            else if (albumName.Length > 50)
            {
                return "Album name must be less or equal than 50 characters!";
            }
            else if (albumDescription.Trim().Equals(""))
            {
                return "Album Description must be filled!";
            }
            else if (albumDescription.Length > 255)
            {
                return "Album description must be less or equal than 255 characters!";
            }
            else if (albumPrice.All(char.IsDigit) == false)
            {
                return "Album price must be a digit!";
            }
            else if (albumStock.All(char.IsDigit) == false)
            {
                return "Album stock must be a digit!";
            }

            int price = Convert.ToInt32(albumPrice);
            int stock = Convert.ToInt32(albumStock);

            if (price < 100000 || price > 1000000)
            {
                return "Album price must be between 100000 and 1000000!";
            }
            else if (stock <= 0)
            {
                return "Album stock must be greater than 0!";
            }

            string imagePath = "../../Assets/Album/";
            string imageUrl = imagePath + albumImage.FileName;
            string fileExtension = Path.GetExtension(albumImage.PostedFile.FileName);
            int fileSizeMB = (albumImage.PostedFile.ContentLength / 1024) / 1024;

            if (albumImage.HasFile == false)
            {
                return "File must not be empty!";
            }
            else if (!fileExtension.Equals(".png") && !fileExtension.Equals(".jpg") && !fileExtension.Equals(".jpeg") && !fileExtension.Equals(".jfif"))
            {
                return "File extension must be .png/.jpg/.jpeg/.jfif only!";
            }
            else if (albumImage.FileName.Length > 50 || albumImage.FileName.Length + imagePath.Length > 50)
            {
                return "File name is too long!";
            }
            else if (fileSizeMB > (2 / 1024) / 1024)
            {
                return "File size is too big!";
            }

            albumImage.SaveAs(HttpContext.Current.Server.MapPath(imageUrl));
            return AlbumHandler.updateAlbum(albumId, albumName, albumDescription, price, stock, imageUrl);
        }

        public static string buyAlbum(int albumId, int quantity)
        {
            return AlbumHandler.buyAlbum(albumId, quantity);
        }
    }
}