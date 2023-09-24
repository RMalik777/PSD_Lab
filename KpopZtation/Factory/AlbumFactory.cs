using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class AlbumFactory
    {
        public static msAlbum createAlbum(string albumName, string albumDescription, int price, int stock, string imageUrl, int artistId)
        {
            msAlbum album = new msAlbum();
            album.AlbumName = albumName;
            album.AlbumDescription = albumDescription;
            album.AlbumPrice = price;
            album.AlbumStock = stock;
            album.AlbumImage = imageUrl;
            album.ArtistID = artistId;
            return album;
        }

    }
}