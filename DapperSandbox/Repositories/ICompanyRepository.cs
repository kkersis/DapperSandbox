using DapperSandbox.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperSandbox.Repositories
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<IEnumerable<Company>> GetCompaniesWithEmployees();
    }
}
