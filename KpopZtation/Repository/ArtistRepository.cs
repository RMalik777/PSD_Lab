using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class ArtistRepository
    {
        public static localDBEntities1 db = new localDBEntities1();

        public static string insertArtist(string name, string image)
        {
            msArtist artist = ArtistFactory.createArtist(name, image);
            db.msArtists.Add(artist);
            db.SaveChanges();

            return "Artist successfully inserted!";
        }

        public static void deleteArtist(int id)
        {
            msArtist artist = (from i in db.msArtists where i.ArtistID == id select i).FirstOrDefault();

            if (artist != null)
            {
                db.msArtists.Remove(artist);
                db.SaveChanges();
            }
            return;
        }

        public static msArtist getArtistById(int id)
        {
            msArtist artist = (from i in db.msArtists where i.ArtistID == id select i).FirstOrDefault();

            if (artist == null) return null;
            return artist;
        }

        public static string updateArtist(int artistId, string artistName, string artistImage)
        {
            msArtist artist = (from i in db.msArtists where i.ArtistID == artistId select i).FirstOrDefault();

            if (artist == null)
            {
                return "Failed to update artist!";
            }

            artist.ArtistName = artistName;
            artist.ArtistImage = artistImage;
            db.SaveChanges();

            return "Artist successfully updated!";
        }

        public static bool isArtistNameExist(string name)
        {
            msArtist artist = (from i in db.msArtists where i.ArtistName.Equals(name) select i).FirstOrDefault();

            if (artist == null) return false;
            return true;
        }

        public static List<msArtist> getAllArtist()
        {
            return db.msArtists.ToList();
        }
    }
}