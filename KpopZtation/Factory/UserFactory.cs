using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class UserFactory
    {
        public static msCustomer createUser(string name, string email, string gender, string address, string password, string role)
        {
            msCustomer customer = new msCustomer();
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerPassword = password;
            customer.CustomerAddress = address;
            customer.CustomerGender = gender;
            customer.CustomerRole = role;

            return customer;
        }

    }
}