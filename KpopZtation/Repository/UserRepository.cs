using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class UserRepository
    {
        public static localDBEntities1 db = new localDBEntities1();
        public static string addUser(string name, string email, string gender, string address, string password, string role)
        {
            msCustomer user = UserFactory.createUser(name, email, gender, address, password, role);
            db.msCustomers.Add(user);
            db.SaveChanges();

            return "Registration Success! Please login";
        }
        public static msCustomer loginUser(string email,string password)
        {
            return (from i in db.msCustomers where i.CustomerEmail == email && i.CustomerPassword == password select i).FirstOrDefault();
        }
        public static string updateCustomer(int id, string name, string email, string gender, string address, string password)
        {
            msCustomer user = (from i in db.msCustomers where i.CustomerID == id select i).FirstOrDefault();
            user.CustomerName = name;
            user.CustomerEmail = email;
            user.CustomerGender = gender;
            user.CustomerAddress = address;
            user.CustomerPassword = password;
            db.SaveChanges();

            return "Successfully changed profile!";
        }

        public static string deleteCustomer(int id)
        {
            msCustomer toDelete = (from i in db.msCustomers where i.CustomerID == id select i).FirstOrDefault();
            db.msCustomers.Remove(toDelete);
            db.SaveChanges();
            return "Successfully deleted profile!";
        }

        public static void deleteUser(int customerId)
        {
            msCustomer customer = (from i in db.msCustomers where i.CustomerID == customerId select i).FirstOrDefault();

            if (customer != null)
            {
                db.msCustomers.Remove(customer);
            }
            db.SaveChanges();
        }
    }
}