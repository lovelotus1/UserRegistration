﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegistrationPattern
    {

        public static string FirstNameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";
        /// <summary>
        /// method for validating user firstName
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public static bool ValidetingFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FirstNameRegex);
        }
    }
}