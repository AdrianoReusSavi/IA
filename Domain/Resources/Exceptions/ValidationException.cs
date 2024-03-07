﻿namespace IA.Domain.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
        {

        }

        public ValidationException(string message) : base(message)
        {

        }

        public ValidationException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}