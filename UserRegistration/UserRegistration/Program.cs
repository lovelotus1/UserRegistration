using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  FirstName :");
            string firstName = Console.ReadLine();
            if (RegistrationPattern.ValidetingFirstName(firstName))
            {
                Console.WriteLine("First Name is VALID !");
            }
            else
            {
                Console.WriteLine("First Name is INVALID !");
            }
            Console.WriteLine("Enter LastName :");
            string LastName = Console.ReadLine();
            if (RegistrationPattern.ValidetingLastName(LastName))
            {
                Console.WriteLine("Last Name is VALID !");
            }
            else
            {
                Console.WriteLine("Last Name is INVALID !");
            }
            Console.WriteLine("Enter email :");
            string Email = Console.ReadLine();
            if (RegistrationPattern.ValidetingEmailAddress(Email))
            {
                Console.WriteLine("email is VALID !");
            }
            else
            {
                Console.WriteLine("email is INVALID !");
            }
            Console.WriteLine("Enter MobileNumber :");
            string MobileNumber = Console.ReadLine();
            if (RegistrationPattern.ValidetingMobileFormat(MobileNumber))
            {
                Console.WriteLine("MobileNumber is VALID !");
            }
            else
            {
                Console.WriteLine("MobileNumber is INVALID !");
            }
            Console.WriteLine("Enter Rule1 PasswordFormat :");
            string RuleOnePasswordFormat = Console.ReadLine();
            if (RegistrationPattern.ValidetingRuleFirstPasswordFormat(RuleOnePasswordFormat))
            {
                Console.WriteLine("Password is VALID !");
            }
            else
            {
                Console.WriteLine("Password is INVALID !");
            }
            Console.WriteLine("Enter Rule2 PasswordFormat :");
            string RuleSecondPasswordFormat = Console.ReadLine();
            if (RegistrationPattern.ValidetingRuleSecondPasswordFormat(RuleSecondPasswordFormat))
            {
                Console.WriteLine("Password is VALID !");
            }
            else
            {
                Console.WriteLine("Password is INVALID !");
            }
            Console.WriteLine("Enter Rule3 PasswordFormat :");
            string RuleThirdPasswordFormat = Console.ReadLine();
            if (RegistrationPattern.ValidetingRuleThirdPasswordFormat(RuleThirdPasswordFormat))
            {
                Console.WriteLine("Password is VALID !");
            }
            else
            {
                Console.WriteLine("Password is INVALID !");
            }
            Console.WriteLine("Enter Rule4 PasswordFormat :");
            string RuleFourthPasswordFormat = Console.ReadLine();
            if (RegistrationPattern.ValidetingRuleFourthPasswordFormat(RuleFourthPasswordFormat))
            {
                Console.WriteLine("Password is VALID !");
            }
            else
            {
                Console.WriteLine("Password is INVALID !");
            }
            Console.WriteLine("Enter SampleEmails :");
            string sampleEmail = Console.ReadLine();
            if (RegistrationPattern.ValidetingEmailSample(sampleEmail))
            {
                Console.WriteLine("Password is VALID !");
            }
            else
            {
                Console.WriteLine("Password is INVALID !");
            }
        }
    }
}