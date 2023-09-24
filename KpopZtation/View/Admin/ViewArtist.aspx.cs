using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Admin
{
    public partial class ViewArtist : System.Web.UI.Page
    {
        public List<msArtist> artists = null;
        public List<msAlbum> albums = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string parameterId = Request.Params["id"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("./Home.aspx");
            }

            artists = ArtistController.getAllArtist();
            int artistId = Int32.Parse(parameterId);
            updateArtistData(artistId);
        }

        protected void updateArtistData(int artistId)
        {
            msArtist artist = ArtistController.getArtistById(artistId);

            if (artist == null)
            {
                Response.Redirect("./Home.aspx");
            }

            lblArtistName.Text = artist.ArtistName;
            imgArtistImage.ImageUrl = artist.ArtistImage;
            imgArtistImage.Width = 200;
            imgArtistImage.Height = 200;

            albums = AlbumController.getAlbumsArtistId(artistId);
            albumList.DataSource = albums;
            albumList.DataBind();
            totalAlbum.Text = "Total: " + albums.Count().ToString() + " album(s)";
        }

        protected void btnInsertAlbum_Click(object sender, EventArgs e)
        {
            string parameterId = Request.Params["id"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("./Home.aspx");
            }
            Response.Redirect("./InsertAlbum.aspx?artistId=" + parameterId);
        }

        protected void btnDeleteAlbum_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                AlbumController.deleteAlbum(Int32.Parse(e.CommandArgument.ToString()));
            }

            string parameterId = Request.Params["id"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("./Home.aspx");
            }

            updateArtistData(Convert.ToInt32(parameterId));
        }

        protected void btnUpdateAlbum_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                Response.Redirect("./UpdateAlbum.aspx?id=" + e.CommandArgument.ToString());
            }
        }
    }
}