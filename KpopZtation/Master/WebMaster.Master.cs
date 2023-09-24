using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.Master
{
    public partial class WebMaster : System.Web.UI.MasterPage
    {
        public static string role;
        protected void Page_Load(object sender, EventArgs e)
        {
            //role = "admin"; // buat test
            // role = (string)Session["role"];
            if(Session["role"] != null)
            {
                role = Session["role"].ToString();
            }
            else
            {
                role = "Guest";
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Guest/GuestLogin.aspx");
        }

        protected void regisBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Guest/GuestRegister.aspx");

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/General/Home.aspx");
        }

        protected void transBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Customers/Transaction.aspx");
        }

        protected void updtBtn_Click(object sender, EventArgs e)
        {
            if(Session["role"] != null && Session["role"].ToString().Equals("Admin"))
            {
                Response.Redirect("~/View/Admin/UpdateProfile.aspx");
            }
            else
            {
                Response.Redirect("~/View/Customers/UpdateProfile.aspx");
            }
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Session.Remove("role");
            Session.RemoveAll();
            Response.Redirect("~/View/Guest/GuestLogin.aspx");
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Customers/Cart.aspx");
        }
    }
}