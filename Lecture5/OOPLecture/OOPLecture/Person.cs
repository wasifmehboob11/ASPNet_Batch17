using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture
{
    public class Person
    {
        public int CNIC { get; set; }
        public string Name { get; set; }
        public string PostalAddress { get; set; }
        public string PermanentAddress { get; set; }

        public List<Phone> Phones { get; set; }
    }
}
