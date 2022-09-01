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
        public static string MobileFormatREGEX = "^[1-9]{1}[0-9]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
        public static string RuleOnePasswordRegex = "^[A-Za-z0-9@$!%*#?&]{8,}$";
        public static string RuleSecondPasswordRegex = "^(?=.*?[A-Z])[A-Za-z0-9@$!%*#?&]{8,}$";
        public static string RuleThirdPasswordRegex = "^(?=.*?[A-Z])(?=.*?[0-9])[A-Za-z0-9@$!%*#?&]{8,}$";
        public static string RuleFourthPasswordRegex = "^[A-Za-z0-9]*[@$!%*#?&]{1}[A-Za-z0-9]*$";
        public static string SampleEmailRegex = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        /// <summary>
        /// method for validating user firstName
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public static bool ValidetingFirstName(string firstName)
        {
            try
            {
                return Regex.IsMatch(firstName, FirstNameRegex);
            }
            catch
            {
                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_FIRSTNAME, "Invalid_FirstName_Format");
            }
        }
        /// <summary>
        /// method for validating LastName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool ValidetingLastName(string name)
        {
            try
            {
                return Regex.IsMatch(name, LastNameRegex);
            }
            catch
            {

                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_LASTNAME, "Invalid_LastName_Format");
            }
        }
        /// <summary>
        /// method validating email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool ValidetingEmailAddress(string email)
        {
            try
            {
                return Regex.IsMatch(email, EmailRegex);
            }
            catch
            {
                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_EMAIL_FORMAT, "Invalid_Email_Format");
            }
        }
        /// <summary>
        /// method valideting Mobile Format
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool ValidetingMobileFormat(string mobile)
        {
            try
            {
                return Regex.IsMatch(mobile, MobileFormatREGEX);
            }
            catch
            {
                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_PHONENUMBER, "Invalid_PhoneNumber");
            }
        }
        /// <summary>
        /// Method for Validating Rule 1 password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ValidetingRuleFirstPasswordFormat(string password)
        { 
            try
            {
                return Regex.IsMatch(password, RuleOnePasswordRegex);
            }
            catch
            {
                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_PASSWORD, "Invalid_FirstRulePassword_Format");
            }
        }
        /// <summary>
        /// method for validating Second rule password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ValidetingRuleSecondPasswordFormat(string password)
        {
            try
            {
                return Regex.IsMatch(password, RuleSecondPasswordRegex);
            }
            catch
            {
                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_PASSWORD, "Invalid_SecondRulePassword_Format");
            }

        }
        /// <summary>
        /// method for validating Third rule password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ValidetingRuleThirdPasswordFormat(string password)
        { 
            try
            {
                return Regex.IsMatch(password, RuleThirdPasswordRegex);
            }
            catch
            {
                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_PASSWORD, "Invalid_ThirdRulePassword_Format");
            }
        }
        /// <summary>
        /// Valideting Rule 4th Password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ValidetingRuleFourthPasswordFormat(string password)
        { 
            try
            {
                return Regex.IsMatch(password, RuleFourthPasswordRegex);
            }
            catch
            {
                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_PASSWORD, "Invalid_FourthRulePassword_Format");
            }
        }
        /// <summary>
        /// method for valideting email sample
        /// </summary>
        /// <param name="emailSample"></param>
        /// <returns></returns>
        public static bool ValidetingEmailSample(string emailSample)
        {
            try
            {
                return Regex.IsMatch(emailSample, SampleEmailRegex);
            }
            catch
            {
                throw new UserRegistrationCustomException(ExceptionTypeEnum.INVALID_EMAIL_FORMAT, "Invalid_Email_Format");
            }
        }

    }
}