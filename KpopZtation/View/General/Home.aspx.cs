using KpopZtation.Controller;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.General
{
    public partial class Home : System.Web.UI.Page
    {
        public static localDBEntities1 db = new localDBEntities1();
        public string role;
        public List<msArtist> artists = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null) //cookie
            {
                //Response.Redirect("~/View/Guest/GuestLogin.aspx");
            }
            //role = (string)Session["role"]; //validasi role
            
            if(Session["role"] != null)
            {
                lblRole.Text = Session["role"].ToString();
                role = Session["role"].ToString();
            }
            else
            {
                lblRole.Text = "Guest";
                role = "Guest";
            }

            getBindData();
            string tArtist = artists.Count() > 1 ? "artists" : "artist";
            totalArtist.Text = "Total: " + artists.Count().ToString() + " " + tArtist;
        }
        string artistPath = HttpContext.Current.Server.MapPath("~/Assets/Artis/");
        protected void getBindData()
        {
            artists = ArtistController.getAllArtist();
            artistList.DataSource = artists;
            artistList.DataBind();

        }

        protected void btnInsertArtist_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/InsertArtist.aspx");
        }

        protected void btnDeleteArtist_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                ArtistController.deleteArtist(Int32.Parse(e.CommandArgument.ToString()));
                getBindData();
                string tArtist = artists.Count() > 1 ? "artists" : "artist";
                totalArtist.Text = "Total: " + artists.Count().ToString() + " " + tArtist;
            }
        }

        protected void btnUpdateArtist_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                Response.Redirect("~/View/Admin/UpdateArtist.aspx?id=" + e.CommandArgument.ToString());
            }
        }
    }
}