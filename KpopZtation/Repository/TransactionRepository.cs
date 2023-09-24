using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class TransactionRepository
    {
        public static localDBEntities1 db = new localDBEntities1();
        /*public static string createTransHeader(int cid)
        {
            msTransactionHeader trans = TransactionFactory.createTransHeader(cid);
            db.msTransactionHeaders.Add(trans);
            db.SaveChanges();

            return "Successfully added transaction!";
        }*/

        public static string removeTransHeader(int cid, int aid)
        {
            msTransactionHeader trans = (from i in db.msTransactionHeaders where i.CustomerID == cid select i).FirstOrDefault();
            db.msTransactionHeaders.Remove(trans);
            db.SaveChanges();

            return "Successfully removed transaction!";

        }

        public static msTransactionHeader insertTransactionHeader(int customerId)
        {
            msTransactionHeader trans = TransactionFactory.createTransHeader(customerId);
            db.msTransactionHeaders.Add(trans);
            db.SaveChanges();

            return trans;
        }

        public static void insertTransactionDetail(int transactionId, int albumId, int quantity)
        {
            msTransactionDetail td = TransactionFactory.createTransDetail(transactionId, albumId, quantity);

            db.msTransactionDetails.Add(td);
            db.SaveChanges();
        }

        public static List<msTransactionHeader> getAllTransactionHeaderByCustomerId(int customerId)
        {
            List<msTransactionHeader> transactions = new List<msTransactionHeader>();

            List<msTransactionHeader> th = db.msTransactionHeaders.ToList();

            foreach(msTransactionHeader t in th)
            {
                if(t.CustomerID == customerId)
                {
                    transactions.Add(t);
                }
            }

            return transactions;
        }

        public static List<msTransactionDetail> getAllTransactionDetailById(int transactionId)
        {
            List<msTransactionDetail> transaction = new List<msTransactionDetail>();

            List<msTransactionDetail> tds = db.msTransactionDetails.ToList();

            foreach(msTransactionDetail td in tds)
            {
                if(td.TransactionID == transactionId)
                {
                    transaction.Add(td);
                }
            }

            return transaction;
        }
    }
}