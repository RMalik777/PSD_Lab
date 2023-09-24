using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Admin
{
    public partial class UpdateArtist : System.Web.UI.Page
    {
        public List<msArtist> artists = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            string parameterId = Request.Params["id"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            if(Session["user"] == null || (Session["role"] != null && !Session["role"].Equals("Admin")))
            {
                Response.Redirect("~/View/General/Home.aspx");
            }


            artists = ArtistController.getAllArtist();
            int artistId = Int32.Parse(parameterId);
            updateArtistData(artistId);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int artistId = Convert.ToInt32(Request.Params["id"]);
            string artistName = txtName.Text;
            FileUpload artistImage = fileImage;

            lblError.Text = ArtistController.updateArtist(artistId, artistName, artistImage);
            updateArtistData(artistId);
        }

        protected void updateArtistData(int artistId)
        {
            msArtist artist = ArtistController.getArtistById(artistId);

            if (artist == null)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            lblArtistName.Text = artist.ArtistName;
            imgArtistImage.ImageUrl = artist.ArtistImage;
            imgArtistImage.Width = 200;
            imgArtistImage.Height = 200;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/General/Home.aspx");
        }
    }
}