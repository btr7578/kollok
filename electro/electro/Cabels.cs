using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace electro
{
    class Cabels
    {
        public string name;
        public double price;
        public double length;
        public Cabels(string n, double p, double l)
        {
            name = n;
            price = p;
            length = l;
        }
        public double GetPrice()
        {
            return price * length;
        }
    }
}
