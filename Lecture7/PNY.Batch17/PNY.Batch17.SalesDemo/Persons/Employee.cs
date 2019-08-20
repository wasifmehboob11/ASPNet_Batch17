using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PNY.Batch17.Common;

namespace PNY.Batch17.SalesDemo.Persons
{
    public abstract class Employee : Person
    {
        public int EmployeeID { get; set; }
        public Decimal Salary { get; set; }
    }
}
