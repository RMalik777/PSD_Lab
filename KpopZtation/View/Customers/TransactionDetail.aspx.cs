using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Customers
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        public int transactionId = 0;
        public int totalItem = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            string parameterId = Request.Params["id"];
            if (parameterId == null || parameterId.All(char.IsDigit) == false)
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            if (Session["user"] == null || (Session["role"] != null && !Session["role"].ToString().Equals("Customer")))
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            transactionId = Convert.ToInt32(parameterId);
            fetchData(transactionId);
        }

        protected void fetchData(int transactionId)
        {
            List<msTransactionDetail> td = TransactionController.getAllTransactionDetailById(transactionId);

            transactionDetailList.DataSource = td;
            transactionDetailList.DataBind();

            totalItem = td.Count();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Customers/Transaction.aspx");
        }
    }
}