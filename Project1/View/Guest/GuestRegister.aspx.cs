using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.View.Guest
{
    public partial class GuestRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string value = "";
            bool isChecked = maleRadio.Checked;
            if (isChecked)
                value = maleRadio.Text;
            else
                value = femaleRadio.Text;
        }
    }
}