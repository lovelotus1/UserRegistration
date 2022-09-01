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
                
        }
    }
}