using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class TransactionFactory
    {
        public static msTransactionHeader createTransHeader(int cid)
        {
            msTransactionHeader trans = new msTransactionHeader();
            trans.CustomerID = cid;
            trans.TransactionDate = DateTime.Now;
            
            return trans;
        }

        public static msTransactionDetail createTransDetail(int tid, int aid, int qty)
        {
            msTransactionDetail trans = new msTransactionDetail();
            trans.TransactionID = tid;
            trans.AlbumID = aid;
            trans.Quantity = qty;

            return trans;
        }

    }
}