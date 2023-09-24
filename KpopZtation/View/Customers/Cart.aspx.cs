using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Customers
{
    public partial class Cart : System.Web.UI.Page
    {
        public List<msCart> carts = null;

        public int totalAlbum = 0;
        public long totalPrice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || (Session["role"] != null && !Session["role"].ToString().Equals("Customer")))
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            fetchCart();
        }

        protected void fetchCart()
        {
            msCustomer customer = (msCustomer) Session["user"];
            carts = null;
            totalPrice = 0;
            carts = CartController.getAllCartByCustomerId(customer.CustomerID);

            cartList.DataSource = carts;
            cartList.DataBind();

            totalAlbum = carts.Count();

            foreach (msCart cart in carts)
            {
                if (cart.msAlbum != null)
                {
                    totalPrice += cart.msAlbum.AlbumPrice * cart.Quantity;
                }
            }
        }

        protected void btnRemove_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                msCustomer customer = (msCustomer)Session["user"];

                int albumId = Convert.ToInt32(e.CommandArgument.ToString());
                int customerId = customer.CustomerID;

                CartController.removeCartByCustomerAlbumId(customerId, albumId);

                fetchCart();
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            msCustomer customer = (msCustomer)Session["user"];

            CartController.cartCheckoutByCustomerId(customer.CustomerID);

            fetchCart();

            lblSuccess.Text = "Checkout success!";
        }
    }
}