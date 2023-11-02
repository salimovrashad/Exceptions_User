using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilities.Exceptions
{
    internal class InvalidAgeException : Exception
    {
		public InvalidAgeException()
		{
		}

		public InvalidAgeException(string? message) : base(message)
        {
        }
    }
}
