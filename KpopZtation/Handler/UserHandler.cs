using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class UserHandler
    {
        public static string addUser(string name, string email, string gender, string address, string password, string role)
        {
            return UserRepository.addUser(name, email, gender, address, password, role);
        }
        public static msCustomer loginUser(string email, string pasword)
        {
            return UserRepository.loginUser(email, pasword);
        }
        public static string updateCustomer(int id, string name, string email, string gender, string address, string password)
        {
            return UserRepository.updateCustomer(id, name,email,gender,address,password);
        }

        public static void deleteUser(int customerId)
        {
            UserRepository.deleteUser(customerId);
        }
    }
}