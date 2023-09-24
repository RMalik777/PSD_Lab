using KpopZtation.Handler;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtation.Controller
{
    public class ArtistController
    {
        public static localDBEntities1 db = new localDBEntities1();
        public static string insertArtist(string name, FileUpload image)
        {
            string imagePath = "../../Assets/Artist/";
            string imageUrl = imagePath + image.FileName;
            string fileExtension = Path.GetExtension(image.PostedFile.FileName);
            int fileSizeMB = (image.PostedFile.ContentLength / 1024) / 1024;
            if (name.Trim().Equals(""))
            {
                return "Artist name must be filled!";
            }
            else if (isArtistNameExist(name))
            {
                return "Artist name must be unique!";
            }
            else if (image.HasFile == false)
            {
                return "File must not be empty!";
            }
            else if (!fileExtension.Equals(".png") && !fileExtension.Equals(".jpg") && !fileExtension.Equals(".jpeg") && !fileExtension.Equals(".jfif"))
            {
                return "File extension must be .png/.jpg/.jpeg/.jfif only!";
            }
            else if (image.FileName.Length > 50 || image.FileName.Length + imagePath.Length > 50)
            {
                return "File name is too long!";
            }
            else if (fileSizeMB > 2)
            {
                return "File size is too big!";
            }

            image.SaveAs(HttpContext.Current.Server.MapPath(imageUrl));
            return ArtistHandler.insertArtist(name, imageUrl);
        }

        public static bool isArtistNameExist(string name)
        {
            return ArtistHandler.isArtistNameExist(name);
        }

        public static void deleteArtist(int id)
        {
            ArtistHandler.deleteArtist(id);
        }

        public static msArtist getArtistById(int id)
        {
            return ArtistHandler.getArtistById(id);
        }

        public static string updateArtist(int artistId, string artistName, FileUpload artistImage)
        {
            string imagePath = "../../Assets/Artist/";
            string imageUrl = imagePath + artistImage.FileName;
            string fileExtension = Path.GetExtension(artistImage.PostedFile.FileName);
            int fileSizeMB = (artistImage.PostedFile.ContentLength / 1024) / 1024;
            if (artistName.Trim().Equals(""))
            {
                return "Artist name must be filled!";
            }
            else if (isArtistNameExist(artistName))
            {
                return "Artist name must be unique!";
            }
            else if (artistImage.HasFile == false)
            {
                return "File must not be empty!";
            }
            else if (!fileExtension.Equals(".png") && !fileExtension.Equals(".jpg") && !fileExtension.Equals(".jpeg") && !fileExtension.Equals(".jfif"))
            {
                return "File extension must be .png/.jpg/.jpeg/.jfif only!";
            }
            else if (artistImage.FileName.Length > 50 || artistImage.FileName.Length + imagePath.Length > 50)
            {
                return "File name is too long!";
            }
            else if (fileSizeMB > 2)
            {
                return "File size is too big!";
            }

            artistImage.SaveAs(HttpContext.Current.Server.MapPath(imageUrl));
            return ArtistHandler.updateArtist(artistId, artistName, imageUrl);
        }

        public static List<msArtist> getAllArtist()
        {
            return ArtistHandler.getAllArtist();
        }
    }
}