using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class TransactionController
    {
        public static List<msTransactionHeader> getAllTransactionHeaderByCustomerId(int customerId)
        {
            return TransactionHandler.getAllTransactionHeaderByCustomerId(customerId);
        }

        public static List<msTransactionDetail> getAllTransactionDetailById(int transactionId)
        {
            return TransactionHandler.getAllTransactionDetailById(transactionId);
        }
    }
}