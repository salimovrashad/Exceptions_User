using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilities.Exceptions
{
	internal class InvalidNameException : Exception
	{
		public InvalidNameException()
		{
		}
		public InvalidNameException(string? message) : base(message)
		{
		}
	}
}
