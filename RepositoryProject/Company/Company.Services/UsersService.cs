using Company.Data.Data;
using Company.Data.Data.Interfaces;
using Company.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services
{
    public class UsersService
    {
        private readonly IUserRepository _userRepository;

        public UsersService(IUserRepository UserRepository)
        {
            _userRepository = UserRepository;
        }

        public void AddCompany(User company)
        {
            _userRepository.AddUser(company);
        }
        public void DeleteCompany(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Id == id);
                if (user != null)
                {
                    _userRepository.DeleteUser(user);
                }
            }

        }
        public void UpdateCompany(int id, User User)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Id == id);

                if (user != null)
                {
                    user.Name = User.Name;
                    user.Surname = User.Surname;
                    user.Position = User.Position;
                    user.Salary = User.Salary;
                    user.CompanyId = User.CompanyId;    
                    user.Company = User.Company;

                    if (isValid(user))
                    {
                        _userRepository.UpdateUser(user);
                    }


                }
            }
        }

        public void PrintAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                try
                {
                    var users = context.Users;
                    foreach (var user in users)
                    {
                        Console.WriteLine($"Name: {user.Name}\n Surname: {user.Surname}\nPosition: {user.Position}\nSalary: {user.Salary}\n______________________");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("User not found");
                }
            }
        }

        public void PrintForId(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                try
                {
                    var user = context.Users.FirstOrDefault(x => x.Id == id);
                    Console.WriteLine($"Name: {user.Name}\n Surname: {user.Surname}\nPosition: {user.Position}\nSalary: {user.Salary}\n______________________");
                }
                catch (Exception)
                {
                    Console.WriteLine("Company not found");
                }
            }
        }

        private static bool isValid(User user)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);

            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (ValidationResult validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
