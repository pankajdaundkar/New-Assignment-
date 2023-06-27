using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
namespace New_Assignment_practice
{	//Create class Product. Add fields like id, name and price.Create properties for each field. Use object initializer syntax initialize the object. Print product details using ToString()
    internal class Product_details
    {
        private int id;
        double price;
        private string name;
        private double dic_per;
        private double cost_pri;
        private double sell_pri;
        public double DiscountAmount { get; set; }
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
        public double Cost
        {
            set { cost_pri = value; }
            get { return cost_pri; }
        }
        public double DiscountPrecentage
        {
            set { dic_per = value; }
            get { return dic_per; }
        }
        public double Sell
        {
            set { sell_pri = value; }
            get { return sell_pri; }
        }
        public void CalculateDis()
        {
            DiscountAmount = Price * DiscountPrecentage / 100;
        }
        public override string ToString()
        {
            return $"product id is {id}\nname is {name}\nprice is {price} discount is {DiscountAmount}";
        }

    }
}