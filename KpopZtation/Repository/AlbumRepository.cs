using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class AlbumRepository
    {
        public static localDBEntities1 db = new localDBEntities1();

        public static List<msAlbum> getAlbumArtistId(int artistId)
        {
            List<msAlbum> albums = new List<msAlbum>();

            foreach (msAlbum album in db.msAlbums)
            {
                if (album.ArtistID == artistId)
                {
                    albums.Add(album);
                }
            }
            return albums;
        }

        public static string insertAlbum(string albumName, string albumDescription, int price, int stock, string imageUrl, int artistId)
        {
            msAlbum album = AlbumFactory.createAlbum(albumName, albumDescription, price, stock, imageUrl, artistId);
            db.msAlbums.Add(album);
            db.SaveChanges();

            return "Album successfully inserted!";
        }

        public static void deleteAlbum(int albumId)
        {
            msAlbum album = (from i in db.msAlbums where i.AlbumID == albumId select i).FirstOrDefault();

            if (album != null)
            {
                db.msAlbums.Remove(album);
                db.SaveChanges();

            }
        }

        public static msAlbum getAlbumById(int albumId)
        {
            msAlbum album = (from i in db.msAlbums where i.AlbumID == albumId select i).FirstOrDefault();
            return album;
        }

        public static string updateAlbum(int albumId, string albumName, string albumDescription, int price, int stock, string imageUrl)
        {
            msAlbum album = (from i in db.msAlbums where i.AlbumID == albumId select i).FirstOrDefault();

            if (album == null)
            {
                return "Failed to update album!";
            }

            album.AlbumName = albumName;
            album.AlbumDescription = albumDescription;
            album.AlbumPrice = price;
            album.AlbumStock = stock;
            album.AlbumImage = imageUrl;
            db.SaveChanges();

            return "Album successfully updated!";
        }

        public static string buyAlbum(int albumId, int quantity)
        {
            msAlbum album = (from i in db.msAlbums where i.AlbumID == albumId select i).FirstOrDefault();

            if(album == null)
            {
                return "Failed to add album!";
            }

            album.AlbumStock -= quantity;
            db.SaveChanges();

            return "Album successfully added to cart!";
        }
    }
}
