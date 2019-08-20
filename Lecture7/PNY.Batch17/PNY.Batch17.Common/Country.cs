using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNY.Batch17.Common
{
    public class Country
    {
        public int ID { get; }
        public string Name { get; set; }

        public Country() { }

        public Country(string name)
        {
            Name = name;
        }

        public Country (int id, string name) : this(name)
        {
            ID = id;
        }
    }
}
