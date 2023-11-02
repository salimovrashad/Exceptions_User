using System.Text.RegularExpressions;
using ConsoleApp1.Utilities.Exceptions;

namespace ConsoleApp1.Models
{
	public class User
    {
        private string _name;
        private int _age;
        private string _phonenumber;
        private string _password;

		public string Name { 
            get => _name;
            set { if (value.Length < 2) throw new InvalidNameException("Ad uzunlugu duz deyil!!!"); 
            }
		}
        public int Age { 
            get => _age; 
            set { 
                if (value < 0) throw new InvalidAgeException("Yas duzgun deyil!!!"); 
            } 
        }
        public string PhoneNumber { 
            get => _phonenumber; 
            set { 
                if (!Regex.IsMatch(value, @"^\d{10}$")) throw new UserValidationException("Nomre uzunlugu duz deyil!!!"); 
            } 
        }
        public string Password { 
            get => _password; 
            set { 
                if (!Regex.IsMatch(value, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")) throw new UserValidationException("Sifre uzunlugu duz deyil!!!"); 
            } 
        }
    }
}
