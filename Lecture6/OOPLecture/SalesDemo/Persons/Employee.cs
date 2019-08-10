using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLecture;

namespace SalesDemo.Persons
{
    public abstract class Employee : Person
    {
        public int EmployeeID { get; set; }
        public Decimal Salary { get; set; }
    }
}
