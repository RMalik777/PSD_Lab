using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Guest
{
    public partial class GuestLogin1 : System.Web.UI.Page
    {
        public static localDBEntities1 db = new localDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool isRemember = cbRemember.Checked;
            string result = UserController.loginUser(email, password);
            lblError.Text = result;

            msCustomer user = (from i in db.msCustomers where i.CustomerEmail.Equals(email) && i.CustomerPassword.Equals(password) select i).FirstOrDefault();

            if (user != null)
            {
                Session["user"] = user;
                Session["role"] = user.CustomerRole;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.CustomerEmail.ToString();
                    cookie.Expires = DateTime.Now.AddHours(3);
                    Response.Cookies.Add(cookie);
                }
                lblError.Text = "Login Succesfully";
                Response.Redirect("~/View/General/Home.aspx");
            }
            else
            {
                lblError.Text = result;
            }

        }
    }
}