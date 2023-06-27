using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Assignment_practice
{//4.Create class Student, with roll no , name , percentage auto implemented properties. Use property initialize syntax to assign the values. Print the student details
//7.Create Student class with roll no, name, accept 3 subjects marks from constructor.Calculate the total marks & percentage.Display student details using ToString()

     public class Student_Details
    {
        private int Maths, Chemistry, Physics;
        private double Total, Percent;
        public int Roll_no { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public string PrintSD()
        {
            return $" Student name is {Name}\nRoll numbre is {Roll_no}\n Percentage is {Percentage}";
        }
            
            public Student_Details(int Maths, int Chemistry, int Physics)
            {
                this.Maths = Maths;
                this.Chemistry = Chemistry;
                this.Physics = Physics;
            }
            public void Calculate()
            {
                Total = Maths + Chemistry + Physics;
                Percent = (Total / 300) * 100;
            }
            public override string ToString()
            {
                return $"The Total is ={Total}\nPercent is ={Percent}";
            }

        
    }
}
