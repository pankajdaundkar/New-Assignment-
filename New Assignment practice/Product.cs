using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Assignment_practice
{
    internal class Product
    {
        public int id;
        public string name;
        public double price;

        public int Id { set; get; }
        public string Name { set; get; }

        public double Price { set; get; }

        public string ToStringP()
        {
            return $"Product name  is {Name}\nProdct id is {Id}\nPrice is {Price}";
        }
    }
}
