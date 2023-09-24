using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CartFactory
    {   
        public static msCart createCart(int cid, int aid, int qty)
        {
            msCart cart = new msCart();
            cart.CustomerID = cid;
            cart.AlbumID = aid;
            cart.Quantity = qty;

            return cart;
        }
    }
}