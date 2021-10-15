using System;
using System.Collections.Generic;
using System.Text;

namespace miniHttp.HTTP.Exceptions
{
    class InternalServerErrorException : Exception
    {
        private const string defaultMessageException = "The Server has encountered an error.";

        public InternalServerErrorException() : base(defaultMessageException)
        {

        }

        public InternalServerErrorException(string message) : base(message)
        {

        }
    }
}
