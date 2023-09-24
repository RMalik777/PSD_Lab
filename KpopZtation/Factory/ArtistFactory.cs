using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class ArtistFactory
    {
        public static msArtist createArtist(string name, string image)
        {
            msArtist artist = new msArtist();
            artist.ArtistName = name;
            artist.ArtistImage = image;
            return artist;
        }
    }
}