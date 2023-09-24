using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Customers
{
    public partial class Transaction : System.Web.UI.Page
    {
        public List<msTransactionHeader> transactions = null;

        public int totalTransaction = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || (Session["role"] != null && !Session["role"].ToString().Equals("Customer")))
            {
                Response.Redirect("~/View/General/Home.aspx");
            }

            msCustomer customer = (msCustomer)Session["user"];
            fetchData(customer.CustomerID);
        }

        protected void fetchData(int customerId)
        {
            transactions = TransactionController.getAllTransactionHeaderByCustomerId(customerId);

            transactionHeaderList.DataSource = transactions;
            transactionHeaderList.DataBind();

            totalTransaction = transactions.Count();

            
        }
    }
}