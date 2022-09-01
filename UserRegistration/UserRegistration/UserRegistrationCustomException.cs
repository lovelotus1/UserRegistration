using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationCustomException : Exception
    {
        // Creating type Variable of type ExceptionType
        private readonly ExceptionTypeEnum type;

        public UserRegistrationCustomException(ExceptionTypeEnum type, string message) : base(message)
        {
            this.type = type;
        }
    }
}