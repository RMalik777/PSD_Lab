using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Admin
{
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string parameterId = Request.Params["id"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            setAlbumData(Convert.ToInt32(parameterId));
        }

        protected void setAlbumData(int albumId)
        {
            msAlbum album = AlbumController.getAlbumById(albumId);

            if (album == null)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            lblAlbumNameCurrent.Text = album.AlbumName;
            imgAlbumImageCurrent.ImageUrl = album.AlbumImage;
            lblAlbumDescriptionCurrent.Text = album.AlbumDescription;
            lblAlbumPriceCurrent.Text = album.AlbumPrice.ToString();
            lblAlbumStockCurrent.Text = album.AlbumStock.ToString();


        }

        protected void btnUpdateAlbum_Click(object sender, EventArgs e)
        {
            string parameterId = Request.Params["id"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }
            int albumId = Convert.ToInt32(parameterId);
            string albumName = txtAlbumName.Text;
            string albumDescription = txtAlbumDescription.Text;
            string albumPrice = txtAlbumPrice.Text;
            string albumStock = txtAlbumStock.Text;
            FileUpload albumImage = fuAlbumImage;

            lblError.Text = AlbumController.updateAlbum(albumId, albumName, albumDescription, albumPrice, albumStock, albumImage);
            setAlbumData(Convert.ToInt32(parameterId));
        }
    }
}