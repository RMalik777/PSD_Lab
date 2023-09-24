using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Admin
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string parameterId = Request.Params["artistId"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            if(Session["user"] == null || (Session["role"] != null && !Session["role"].Equals("Admin")))
            {
                Response.Redirect("~/View/General/Home.aspx");
            }
        }

        protected void btnInsertAlbum_Click(object sender, EventArgs e)
        {
            string parameterId = Request.Params["artistId"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }
            int artistId = Convert.ToInt32(parameterId);
            string albumName = txtAlbumName.Text;
            string albumDescription = txtAlbumDescription.Text;
            string albumPrice = txtAlbumPrice.Text;
            string albumStock = txtAlbumStock.Text;
            FileUpload albumImage = fuAlbumImage;

            lblError.Text = AlbumController.insertAlbum(albumName, albumDescription, albumPrice, albumStock, albumImage, artistId);
        }
    }
}