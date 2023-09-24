using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class ArtistHandler
    {
        public static string insertArtist(string name, string image)
        {
            return ArtistRepository.insertArtist(name, image);
        }

        public static void deleteArtist(int id)
        {
            ArtistRepository.deleteArtist(id);
        }

        public static msArtist getArtistById(int id)
        {
            return ArtistRepository.getArtistById(id);
        }

        public static string updateArtist(int artistId, string artistName, string artistImage)
        {
            return ArtistRepository.updateArtist(artistId, artistName, artistImage);
        }

        public static bool isArtistNameExist(string name)
        {
            return ArtistRepository.isArtistNameExist(name);
        }

        public static List<msArtist> getAllArtist()
        {
            return ArtistRepository.getAllArtist();
        }
    }
}