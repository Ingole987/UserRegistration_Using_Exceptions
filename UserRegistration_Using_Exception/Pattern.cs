using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Using_Exception
{
    internal class Pattern
    {
        public string FIRSTNAME = "^[A-Z][a-z]{2,}$";
        public bool ValidateFirstName(string input)
        {
            return Regex.IsMatch(input, FIRSTNAME);
        }
        ///////////////////////////////////////////
        public string LASTNAME = "^[A-Z][a-z]{2,}$";
        public bool ValidateLastName(string input)
        {
            return Regex.IsMatch(input, LASTNAME);
        }
        //////////////////////////////////////////
        public string EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public bool ValidateEmail(string input)
        {
            return Regex.IsMatch(input, EMAIL);
        }
        /////////////////////////////////////////
        public string MOBILENUMBER = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        public bool ValidateMobileNumber(string input)
        {
            return Regex.IsMatch(input, MOBILENUMBER);
        }
        ////////////////////////////////////////
        public static string PASSWORD = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])[A-Za-z0-9!@#$%^&*]{8,20}$";
        public bool ValidatePassword(string input)
        {
            return Regex.IsMatch(input, PASSWORD);
        }

    }
}
