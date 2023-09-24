using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.General
{
    public partial class ViewAlbum : System.Web.UI.Page
    {
        public string artistName = "";
        public string albumName = "";
        public string albumImage = "";
        public string albumPrice = "";
        public string albumStock = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string parameterId = Request.Params["id"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            if(Session["user"] == null || (Session["role"] != null && !Session["role"].ToString().Equals("Customer")))
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            fetchData(Convert.ToInt32(parameterId));
        }

        public void fetchData(int albumId)
        {
            msAlbum album = AlbumController.getAlbumById(albumId);
            msArtist artist = ArtistController.getArtistById(album.ArtistID);

            if(album == null || artist == null)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            artistName = artist.ArtistName;
            albumName = album.AlbumName;
            albumImage = album.AlbumImage;
            albumPrice = album.AlbumPrice.ToString();
            albumStock = album.AlbumStock.ToString();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            string quantity = txtQuantity.Text;

            if(quantity.Trim().Equals(""))
            {
                lblError.Text = "Quantity must be filled!";
            }
            else if(!quantity.All(Char.IsDigit))
            {
                lblError.Text = "Quantity must be a number!";
            }
            else if(Convert.ToInt32(quantity) > Convert.ToInt32(albumStock))
            {
                lblError.Text = "Quantity must not greater than album stock!";
            }
            else
            {
                int albumId = Convert.ToInt32(Request.Params["id"]);
                msCustomer customer = (msCustomer)Session["user"];

                if(CartController.isAlbumInCart(customer.CustomerID, albumId))
                {
                    lblError.Text = "This album is already in your cart!";
                    return;
                }
                

                string result = AlbumController.buyAlbum(albumId, Convert.ToInt32(quantity));

                if(result.Equals("Album successfully added to cart!"))
                {
                    result = CartController.addCart(customer.CustomerID, albumId, Convert.ToInt32(quantity));
                }
                lblError.Text = result;
            }
        }
    }
}