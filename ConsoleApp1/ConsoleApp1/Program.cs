using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		
			static void Main(string[] args)
			{
				do
				{
					User user = new User();
					a:
					try
					{
						Console.WriteLine("Enter Name");
						user.Name = Console.ReadLine();
						
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					goto a;
					}
					
					b:
					try
					{
						Console.WriteLine("Enter Age");
						user.Age = Convert.ToInt32(Console.ReadLine());

					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					goto b;
					}

					c:
					try
					{
						Console.WriteLine("Enter PhoneNumber");
						user.PhoneNumber = Console.ReadLine();

					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					goto c;
					}
					
					d:
					try
					{
						Console.WriteLine("Enter Password");
						user.Password = Console.ReadLine();

					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					goto d;
					}
			} while (true);
			}

		}
}