using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Assignment_practice
{
    public class Product_details
    {
        private int id;
        double price;
        private string name;
        private double dic_per, NewPrice, DiscountPrice;

        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price

        {
            set { price = value; }
            get { return price; }
        }

        public double dic_per
        {
            set { dic_per = value; }
            get { return dic_per; }
        }

        public void CalculateDis()

        {
            DiscountPrice = Price * (dic_per /100);
            NewPrice = Price - DiscountPrice;
        }

            public string DisplayP()
        {
            return $"Price is {price},discounted price is {DiscountPrice}";
        }
        public override string ToString()

        {
            return $"product id is {ID}:name is {Name}:price is {Price}:discount price is {DiscountAmount}";
        }
    }
}
