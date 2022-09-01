using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegistrationPatternLamda
    {
        public static string FirstNameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LastNameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EmailRegex = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string MobileFormatREGEX = "^[1-9]{1}[0-9]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
        public static string RulePasswordRegex = "^[A-Za-z0-9]*[@$!%*#?&]{1}[A-Za-z0-9]*$";

        /// <summary>
        /// validatesFirstName;
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public static bool ValidatingFirstName(string firstName) => (Regex.IsMatch(firstName, FirstNameRegex));
        /// <summary>
        /// ValidatingLastName
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public static bool ValidatingLastName(string lastName) => (Regex.IsMatch(lastName, LastNameRegex));

        /// <summary>
        /// Validats the email.
        /// </summary>
        /// <param name="eMail">The e mail.</param>
        /// <returns></returns>
        public static bool ValidatingEmail(string eMail) => (Regex.IsMatch(eMail, EmailRegex));

        /// <summary>
        /// Validates the mobile number.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns></returns>
        public static bool ValidateMobileNumber(string mobileNumber) => (Regex.IsMatch(mobileNumber, MobileFormatREGEX));

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public static bool ValidatePassword(string password) => (Regex.IsMatch(password, RulePasswordRegex));
    }
}