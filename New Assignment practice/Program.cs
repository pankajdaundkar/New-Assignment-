using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using static New_Assignment_practice.Student_Details;

namespace New_Assignment_practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee_details e1 = new Employee_details(123, "pankaj", 30000);
            e1.CalculateSal();
            Console.WriteLine(e1.ToString());

            Product_details p1 = new Product_details() { ID = 123, Name = "pratik", Price = 20000 };
            Console.WriteLine($"product details are { p1.ID}:{ p1.Name}:{p1.Price}");

            Product_details p2 = new Product_details();
            p2.ID = 111;
            p2.Name = "pankaj";
            p2.Price = 30000; 
            p2.DiscountPrecentage = 20;
            p2.CalculateDis();
            Console.WriteLine(p2);


            Student_Details s1 = new Student_Details(80, 70, 75);
            s1.Roll_no = 123;
            s1.Name = "pankaj";
            s1.Percentage = 88;
            Console.WriteLine(s1.PrintSD());

            Student_Details s2 = new Student_Details(85, 93, 87);
            s2.Calculate();
            Console.WriteLine(s2);

        }
    }
}
