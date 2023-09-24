using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CartHandler
    {
        public static string addCart(int customerId, int albumId, int quantity)
        {
            return CartRepository.createCart(customerId, albumId, quantity);
        }

        public static bool isAlbumInCart(int customerId, int albumId)
        {
            return CartRepository.isAlbumInCart(customerId, albumId);
        }

        public static List<msCart> getAllCartByCustomerId(int customerId)
        {
            return CartRepository.getAllCartByCustomerId(customerId);
        }

        public static void removeCartByCustomerAlbumId(int customerId, int albumId)
        {
            CartRepository.removeCartByCustomerAlbumId(customerId, albumId);
        }

        public static void cartCheckoutByCustomerId(int customerId)
        {
            CartRepository.cartCheckoutByCustomerId(customerId);
        }
    }
}