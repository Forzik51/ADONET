using _19._01._22._02version.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._01._22._02version
{
    class Program
    {
        
        //static void Print(var users)
        //{
        //    foreach (var user in users)
        //    {
        //        Console.WriteLine($"Id: {user.UsersID}\nName: {user.Name}\nSurname: {user.Surname}");
        //    }
        //}
        static void Main(string[] args)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var Cities = context.SelectALLCities();
                foreach (var Citi in Cities)
                {
                    Console.WriteLine($"Id: {Citi.Id}\nCountry: {Citi.Country}\nName: {Citi.Name}\nPeople: {Citi.People}\nPartOfTheForld: {Citi.PartOfTheForld}");
                }
            }

            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                Console.WriteLine("Enter Country: ");
                string country = Console.ReadLine();
                var Cities = context.Countries.Where(u => u.name == country);
                foreach (var Citi in Cities)
                {
                    Console.WriteLine($"Id: {Citi.Id}\nName: {Citi.name}\nPeople: {Citi.People}\nPartOfTheForld: {Citi.PartOfTheForld}");
                }
            }

            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                Console.WriteLine("Enter Country: ");
                string country = Console.ReadLine();
                var Cities = context.Cities.Where(u => u.Country == country);
                foreach (var Citi in Cities)
                {
                    Console.WriteLine($"Id: {Citi.Id}\nCountry: {Citi.Country}\nName: {Citi.Name}\nPeople: {Citi.People}\nPartOfTheForld: {Citi.PartOfTheForld}");
                }
            }
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                Console.WriteLine("Enter let Country: ");
                string country = Console.ReadLine();
                var Cities = context.Countries.Where(u => u.name == $@"{country}\w*");
                foreach (var Citi in Cities)
                {
                    Console.WriteLine($"Id: {Citi.Id}\nName: {Citi.name}\nPeople: {Citi.People}\nPartOfTheForld: {Citi.PartOfTheForld}");
                }
            }

            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var Cities = (from user in context.Cities orderby user.People descending select user).Take(3);
                foreach (var Citi in Cities)
                {
                    Console.WriteLine($"Id: {Citi.Id}\nCountry: {Citi.Country}\nName: {Citi.Name}\nPeople: {Citi.People}\nPartOfTheForld: {Citi.PartOfTheForld}");
                }
            }

            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var Cities = (from user in context.Countries orderby user.People descending select user).Take(3);
                foreach (var Citi in Cities)
                {
                    Console.WriteLine($"Id: {Citi.Id}\nCountry: {Citi.name}\nPeople: {Citi.People}\nPartOfTheForld: {Citi.PartOfTheForld}");
                }
            }
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var Cities = (from user in context.Cities select user).Where(u=> u.Country == "China");
                int k = 0,avg = 0;

                foreach (var Citi in Cities)
                {
                    k++;
                    avg += Citi.People;
                }

                foreach (var Citi in Cities)
                {
                    Console.WriteLine($"Country: {Citi.Country}\nPeople: {avg/k}");
                }
            }
        }
    }
}
