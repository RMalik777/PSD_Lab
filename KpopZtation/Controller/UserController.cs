using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace KpopZtation.Controller
{
    public class UserController
    {
        public static localDBEntities1 db = new localDBEntities1();

        public static bool checkName(string name)
        {
            if (name.Length < 5 || 50 < name.Length)
            {
                return true;
            }
            return false;
        }
        public static bool checkEmail(string email)
        {
            if ((from i in db.msCustomers where i.CustomerEmail == email select i).FirstOrDefault() != null)
            {
                return true;
            }
            return false;
        }
        public static bool checkAddress(string address)
        {
            if (!(address.ToLower().EndsWith("street")))
            {
                return true;
            }
            return false;
        }
        public static bool checkPassword(string password)
        {
            if (!(Regex.IsMatch(password, "^[a-zA-Z0-9]*$")))
            {
                return true;
            }
            return false;
        }
        public static string addUser(string name, string email, string gender, string address, string password, string role)
        {
            string Tname = name.Trim();
            email = email.Trim().ToLower();
            string Taddress = address.Trim();
            string Tpassword = password.Trim();

            if (Tname.Equals("") || email.Equals("") || Taddress.Equals("") || Tpassword.Equals("") || gender.Trim().Equals(""))
            {
                return "Failed! Please fill all the forms correctly!";
            }
            if (checkName(Tname))
            {
                return "Name must be 5-50 characters!";
            }
            if (checkEmail(email))
            {
                return "Email already in use!";
            }
            if (checkAddress(address))
            {
                return "Address not correct, please end with the word 'Street'!";
            }
            if (checkPassword(Tpassword))
            {
                return "Password must contain letter and number only!";
            }
            return UserHandler.addUser(name,email,gender,address,password,role);
        }

        public static string loginUser(string email, string password)
        {
            email = email.ToLower();
            if (email.Trim().Equals(""))
            {
                return "Email can't be empty";
            }
            if (password.Trim().Equals(""))
            {
                return "Password can't be empty";
            }
            if (checkEmail(email))
            {
                if (checkPassword(password))
                {
                    return "Password can only contain alphanumeric!";
                }
                msCustomer user = UserHandler.loginUser(email, password);
                if (user != null)
                {
                    return "Approved";
                }
                return ("Password is incorrect!");
            }
            return "Email is not registered, please register!";
        }

        public static string updateUser(int id, string name, string email, string gender, string address, string password)
        {
            string Tname = name.Trim();
            email = email.Trim().ToLower();
            string Taddress = address.Trim();
            string Tpassword = password.Trim();
            if (Tname.Equals("") || email.Equals("") || Taddress.Equals("") || Tpassword.Equals("") || gender.Trim().Equals(""))
            {
                return "Failed! Please fill all the forms correctly!";
            }
            if (checkName(Tname))
            {
                return "Name must be 5-50 characters!";
            }
            if (checkEmail(email))
            {
                return "Email already in use!";
            }
            if (checkAddress(address))
            {
                return "Address not correct, please end with the word 'Street'!";
            }
            if (checkPassword(Tpassword))
            {
                return "Password must contain letter and number only!";
            }
            return UserHandler.updateCustomer(id, name, email, gender, address, password);
            
        }

        public static void deleteUser(int customerId)
        {
            UserHandler.deleteUser(customerId);
        }
    }
}