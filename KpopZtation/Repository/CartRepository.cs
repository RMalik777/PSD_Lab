using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CartRepository
    {
        public static localDBEntities1 db = new localDBEntities1();

        public static string createCart(int cid, int aid, int qty)
        {
            msCart cart = CartFactory.createCart(cid, aid, qty);
            db.msCarts.Add(cart);
            db.SaveChanges();

            return "Successfully added to cart!";
        }

        public static string removeCart(int cid, int aid)
        {
            msCart cart = (from i in db.msCarts where i.CustomerID == cid && i.AlbumID == aid select i).FirstOrDefault();
            db.msCarts.Remove(cart);
            db.SaveChanges();

            return "Successfully removed from cart!";

        }

        public static bool isAlbumInCart(int customerId, int albumId)
        {
            msCart cart = (from i in db.msCarts where i.CustomerID == customerId && i.AlbumID == albumId select i).FirstOrDefault();

            if (cart == null) return false;
            return true;
        }

        public static List<msCart> getAllCartByCustomerId(int customerId)
        {
            List<msCart> carts = new List<msCart>();

            List<msCart> cartList = db.msCarts.ToList();

            foreach(msCart cart in cartList)
            {
                if(cart.CustomerID == customerId)
                {
                    carts.Add(cart);
                }
            }
            return carts;
        }

        public static void removeCartByCustomerAlbumId(int customerId, int albumId)
        {
            msCart cart = (from i in db.msCarts where i.CustomerID == customerId && i.AlbumID == albumId select i).FirstOrDefault();

            cart.msAlbum.AlbumStock += cart.Quantity;
            db.msCarts.Remove(cart);
            db.SaveChanges();
        }

        public static void removeCartCheckoutByCustomerAlbumId(int customerId, int albumId)
        {
            msCart cart = (from i in db.msCarts where i.CustomerID == customerId && i.AlbumID == albumId select i).FirstOrDefault();

            db.msCarts.Remove(cart);
            db.SaveChanges();
        }

        public static void cartCheckoutByCustomerId(int customerId)
        {
            /* List<msTransactionHeader> th = db.msTransactionHeaders.ToList();

             int transactionId = 1;

             foreach(msTransactionHeader trans in th)
             {
                 if(trans.TransactionID > transactionId)
                 {
                     transactionId = trans.TransactionID;
                 }
             }*/

            msTransactionHeader th = TransactionRepository.insertTransactionHeader(customerId);

            List<msCart> carts = getAllCartByCustomerId(customerId);

            foreach(msCart cart in carts)
            {
                TransactionRepository.insertTransactionDetail(th.TransactionID, cart.AlbumID, cart.Quantity);
                removeCartCheckoutByCustomerAlbumId(customerId, cart.AlbumID);
            }
        }
    }
}