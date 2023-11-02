using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilities.Exceptions
{
	internal class UserValidationException : Exception
	{
		public UserValidationException()
		{
		}
		public UserValidationException(string? message) : base(message)
		{
		}
	}
}
