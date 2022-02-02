using Company.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Data.Interfaces
{
    public interface ICompanyRepository
    {
        void AddCompany(ITCompany company);
        void UpdateCompany(ITCompany company);
        void DeleteCompany(ITCompany company);
    }
}
