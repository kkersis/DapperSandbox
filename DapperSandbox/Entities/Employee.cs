using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperSandbox.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int CompanyId { get; set; }
    }
}
