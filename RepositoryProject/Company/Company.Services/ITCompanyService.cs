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
    public class ITCompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public ITCompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void AddCompany(ITCompany company)
        {
            _companyRepository.AddCompany(company);
        }
        public void DeleteCompany(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var user = context.ITCompanies.FirstOrDefault(x => x.Id == id);
                if (user != null)
                {
                    _companyRepository.DeleteCompany(user);
                }
            }
                
        }
        public void UpdateCompany(int id,ITCompany company)
        {
            using(AppDbContext context = new AppDbContext())
            {
                var user = context.ITCompanies.FirstOrDefault(x => x.Id == id);

                if(user != null)
                {
                    user.Name = company.Name;

                    user.Users = company.Users;

                    if(isValid(user))
                    {
                        _companyRepository.UpdateCompany(user);
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
                    var user = context.ITCompanies;
                    foreach (var company in user)
                    {
                        Console.WriteLine($"Company name: {company.Name}\n______________________");
                    }
                }
                catch (Exception )
                {
                    Console.WriteLine("Company not found");
                }
            }
        }

        public void PrintForId(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                try
                {
                    var user = context.ITCompanies.FirstOrDefault(x => x.Id == id);
                    Console.WriteLine($"Company name: {user.Name}\n______________________");
                }
                catch (Exception)
                {
                    Console.WriteLine("Company not found");
                }
            }
        }

        private static bool isValid(ITCompany company)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(company);

            if(!Validator.TryValidateObject(company,context,results,true))
            {
                foreach(ValidationResult validationResult in results)
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
