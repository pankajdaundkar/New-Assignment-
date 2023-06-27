using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Assignment_practice
{//1.	Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF. Accept the value of id, name & basic salary from constructor. Calculate the employee gross salary  & display employee details using ToString() method
 //	HRA- 40% of basic salary
 //TA – 20% of basic salary
 //PF -12 % of basic salary

    public class Employee_details
    {
        private int id, bs;
        private string name;
        private double hra,gs, ta, pf;

        public Employee_details(int id, string name, int bs)
        {

            this.id = id;
            this.bs = bs;
            this.name = name;
        }
        public void CalculateSal()
        {

            hra = bs * 0.40;

            ta = bs * 0.20;

            pf = bs * 0.12;

            gs = (hra + ta + bs) - pf;

        }
        public string ToString()
        {
            return $"Name is {name}\nid is {id}\ngross salary is {gs}";
        }  
    }      
}
