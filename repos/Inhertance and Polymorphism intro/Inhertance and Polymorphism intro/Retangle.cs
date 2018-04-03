using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    public class Retangle : Shape
    {
        private double area;

        public Retangle(double area)
        {
            this.area = area;
        }
        // a dirived does NOT inherit the constructors of the base class constructors cant be accessed by usung "base" keyword
        public Retangle(double area)
        {
            this.area = area;
        }


        public double Area  //<--- note capital 
        {
            get { return this.area; }
            set { this.area = value; }
        }













    }
}
