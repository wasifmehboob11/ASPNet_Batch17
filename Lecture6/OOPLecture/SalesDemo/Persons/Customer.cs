using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLecture;

namespace SalesDemo.Persons
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }

        public Customer() { }
        public Customer(string name) : base(name) { }
    }
}
