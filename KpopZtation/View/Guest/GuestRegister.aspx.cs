using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Guest
{
    public partial class GuestRegister1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }
        }
        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            string gender = "";
            string role = "Customer";
            bool isChecked = maleRadio.Checked;
            if (isChecked)
                gender = maleRadio.Text;
            else
                gender = femaleRadio.Text;
            
            string output = UserController.addUser(name, email, gender, address, password, role);
            lblError.Text = output;
        }
    }
}