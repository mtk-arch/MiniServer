using System;
using System.Collections.Generic;
using System.Text;

namespace miniHttp.HTTP.Exceptions
{
    class BadRequestException : Exception
    {
        private const string exceptionDefaultMessage = "The Request was malformed or contains unsupported elements";

        public BadRequestException() : base(exceptionDefaultMessage) { }
        public BadRequestException(string message) : base(message) { }
    }
}
