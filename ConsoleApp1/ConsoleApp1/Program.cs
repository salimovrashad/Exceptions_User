using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		
			static void Main(string[] args)
			{
				do
				{
					try
					{
						User user = new User();
						Console.WriteLine("Enter Name");
						user.Name = Console.ReadLine();
						Console.WriteLine("Enter Surname");
						user.Age = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter Username");
						user.PhoneNumber = Console.ReadLine();
						Console.WriteLine("Enter Password");
						user.Password = Console.ReadLine();
				}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				} while (true);
			}

		}
}