using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperSandbox.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
