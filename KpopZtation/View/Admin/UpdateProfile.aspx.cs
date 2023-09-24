using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Admin
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msCustomer user = (msCustomer)Session["user"];
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/Guest/GuestLogin.aspx");
            }
            lblOldName.Text = user.CustomerName;
            lblOldEmail.Text = user.CustomerEmail;
            lblOldGender.Text = user.CustomerGender;
            lblOldAddress.Text = user.CustomerAddress;
            lblOldPassword.Text = user.CustomerPassword;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            msCustomer user = (msCustomer)Session["user"];
            int id = user.CustomerID;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            string gender = "";
            bool isChecked = maleRadio.Checked;
            if (isChecked)
                gender = maleRadio.Text;
            else
                gender = femaleRadio.Text;
            string result = UserController.updateUser(id, name, email, gender, address, password);
            lblError.Text = result;
        }

        protected void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            msCustomer user = (msCustomer)Session["user"];
            UserController.deleteUser(user.CustomerID);

            Session.RemoveAll();
            Session["user"] = null;
            Session["role"] = null;
            Session["userid"] = null;
            Response.Redirect("~/View/Guest/GuestLogin.aspx");
        }
    }
}