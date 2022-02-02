using Company.Data.Data.Classes;
using Company.Data.Data.Models;
using Company.Services;
using System;
using System.Linq;

namespace Company.Cmd
{
    class Program
    {
       

        static void Main(string[] args)
        {
            ITCompanyService _companyService = new ITCompanyService(new CompanyRepository());
            UsersService _userService = new UsersService(new UserRepository());
            AcademyService _academyService = new AcademyService(new AcademyRepository());

            //Console.WriteLine("Company name: ");
            //var name = Console.ReadLine();
            //ITCompany iTCompany = new ITCompany()
            //{
            //    Name = name
            //};

            //_companyService.AddCompany(iTCompany);


            ITCompany iTCompany = new ITCompany()
            {
                Name = "SoftServe2"
            };

            //_companyService.UpdateCompany(2,iTCompany);

            //_companyService.PrintAll();

            _userService.PrintAll();



        }
    }
}
