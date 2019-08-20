using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PNY.Batch17.Common;

namespace PNY.Batch17.SalesDemo.Persons
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }

        public Customer() { }
        public Customer(string name) : base(name) { }
    }
}
