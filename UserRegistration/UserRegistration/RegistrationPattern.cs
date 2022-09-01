using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegistrationPattern
    {

        public static string FirstNameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LastNameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EmailRegex = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        /// <summary>
        /// method for validating user firstName
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public static bool ValidetingFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FirstNameRegex);
        }
        /// <summary>
        /// method for validating LastName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool ValidetingLastName(string name)
        {
            return Regex.IsMatch(name, LastNameRegex);
        }
        public static bool ValidetingEmailAddress(string email)
        {
            return Regex.IsMatch(email, EmailRegex);
        }
    }
}