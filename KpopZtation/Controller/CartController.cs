using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class CartController
    {
        public static string addCart(int customerId, int albumId, int quantity)
        {
            return CartHandler.addCart(customerId, albumId, quantity);
        }

        public static bool isAlbumInCart(int customerId, int albumId)
        {
            return CartHandler.isAlbumInCart(customerId, albumId);
        }

        public static List<msCart> getAllCartByCustomerId(int customerId)
        {
            return CartHandler.getAllCartByCustomerId(customerId);
        }

        public static void removeCartByCustomerAlbumId(int customerId, int albumId)
        {
            CartHandler.removeCartByCustomerAlbumId(customerId, albumId);
        }

        public static void cartCheckoutByCustomerId(int customerId)
        {
            CartHandler.cartCheckoutByCustomerId(customerId);
        }
    }
}