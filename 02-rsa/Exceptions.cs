using System;

namespace Rsa
{
    public class NotPrimeException : Exception
    {
        public NotPrimeException() { }
        public NotPrimeException(string message) : base(message) { }
        public NotPrimeException(string message, Exception inner) : base(message, inner) { }
    }

    public class NotPositiveException : Exception
    {
        public NotPositiveException() { }
        public NotPositiveException(string message) : base(message) { }
        public NotPositiveException(string message, Exception inner) : base(message, inner) { }
    }
}
