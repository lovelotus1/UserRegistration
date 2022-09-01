using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserRegistrationTest1
{
    [TestClass]
    public class UnitTest1
    {
        RegistrationPattern pattern = new RegistrationPattern();
        /// <summary>
        /// TestMethod for testing first name
        /// </summary>
        [TestMethod]
        public void Given_First_Name_Should_Returrns_True()
        {
            try
            {
                bool result = RegistrationPattern.ValidetingFirstName("Aayush");
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// test method for checking false condition
        /// </summary>
        [TestMethod]
        public void Given_First_Name_Should_Returrns_False()
        {
            try
            {
                bool result = RegistrationPattern.ValidetingFirstName("aayush");
                Assert.AreEqual(false, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// test cases for lastName;
        /// </summary>
        [TestMethod]
        public void Given_Last_Name_Should_Returrns_True()
        {
            try
            {
                bool result = RegistrationPattern.ValidetingLastName("Aryan");
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }

        [TestMethod]
        public void Given_Last_Name_Should_Returrns_False()
        {
            try
            {
                bool result = RegistrationPattern.ValidetingLastName("aryan");
                Assert.AreEqual(false, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// uc11
        /// validating Multiple entry Paramerized Test
        /// </summary>
        /// <param name="email"></param>
        [DataRow("xyz@yl.co")]
        [DataRow("bridge.co@co.com")]
        [DataRow("bridge.co@bl.com")]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc.xyz@bl.co")]
        [TestMethod]
        public void Given_Email_Should_Returrns_True(string email)
        {
            try
            {
                bool result = RegistrationPattern.ValidetingEmailAddress(email);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }

        [TestMethod]
        public void Given_Email_Should_Returrns_False()
        {
            try
            {
                bool result = RegistrationPattern.ValidetingEmailAddress("abc.@gmail.com.com.com");
                Assert.AreEqual(false, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Given_Mobile_Should_Returrns_True()
        {
            try
            {
                bool result = RegistrationPattern.ValidetingMobileFormat("91 9999955555");
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }

        [TestMethod]
        public void Given_Mobile_Should_Returrns_False()
        {
            try
            {
                bool result = RegistrationPattern.ValidetingMobileFormat("1234567890");
                Assert.AreEqual(false, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
        [DataRow("abc$1234")]
        [DataRow("ABC@1234")]
        [TestMethod]
        public void Given_Password_Should_Returrns_True(string password)
        {
            try
            {
                bool result = RegistrationPattern.ValidetingRuleFourthPasswordFormat(password);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
        [TestMethod]
        public void Given_Password_Should_Returrns_False()
        {
            try
            {
                bool result = RegistrationPattern.ValidetingRuleFourthPasswordFormat("123452345");
                Assert.AreEqual(false, result);
            }
            catch (UserRegistrationCustomException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}