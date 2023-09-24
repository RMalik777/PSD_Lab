using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class TransactionHandler
    {
        public static List<msTransactionHeader> getAllTransactionHeaderByCustomerId(int customerId)
        {
            return TransactionRepository.getAllTransactionHeaderByCustomerId(customerId);
        }

        public static List<msTransactionDetail> getAllTransactionDetailById(int transactionId)
        {
            return TransactionRepository.getAllTransactionDetailById(transactionId);
        }
    }
}