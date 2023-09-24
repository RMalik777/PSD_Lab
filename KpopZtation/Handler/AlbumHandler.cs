using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class AlbumHandler
    {
        public static List<msAlbum> getAlbumArtistId(int artistId)
        {
            return AlbumRepository.getAlbumArtistId(artistId);
        }

        public static string insertAlbum(string albumName, string albumDescription, int price, int stock, string imageUrl, int artistId)
        {
            return AlbumRepository.insertAlbum(albumName, albumDescription, price, stock, imageUrl, artistId);
        }

        public static void deleteAlbum(int albumId)
        {
            AlbumRepository.deleteAlbum(albumId);
        }

        public static msAlbum getAlbumById(int albumId)
        {
            return AlbumRepository.getAlbumById(albumId);
        }

        public static string updateAlbum(int albumId, string albumName, string albumDescription, int price, int stock, string imageUrl)
        {
            return AlbumRepository.updateAlbum(albumId, albumName, albumDescription, price, stock, imageUrl);
        }

        public static string buyAlbum(int albumId, int quantity)
        {
            return AlbumRepository.buyAlbum(albumId, quantity);
        }
    }
}