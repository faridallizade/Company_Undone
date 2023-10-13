using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company
{
    internal class Company
    {
        public User[] users = new User[10];
        public string Name { get; set; }


        public Company(string Name)
        {
            this.Name = Name;
        }

        public void Register()
        {

            Console.WriteLine("Enter the name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the surname : ");
            string Surname = Console.ReadLine();
            User user = new User();

            while (true)
            {
                user.Name = Name;
                user.Surname = Surname;
                Console.WriteLine("Enter the password : ");
                string PassWord = Console.ReadLine();


                if(PassWord.Length >= 5)
                {

                    string UserEmail = $"{user.Name}.{user.Surname}@gmail.com";
                    string UserName = $"{user.Name}.{user.Surname}";
                    Console.WriteLine($"{UserEmail}\n{UserName}");
                    user.Password = PassWord;
                    users[0] = user; //Array.resize nan arraya elave eliyeceksen
                    break;
                }

            }
        }

        public void Login(string ) //string Username istiyecek
        {
            Console.WriteLine();
        }

    }
}
