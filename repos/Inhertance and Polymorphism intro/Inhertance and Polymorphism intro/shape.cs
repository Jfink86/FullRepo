using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    public class Shape
    {
        //Fields 

        private int sides;

        //Properties 

        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        //constructors

        public Shape()
        {
            ///default
        }

        public Shape( int sides)
        {
            this.sides = sides;
        }










    }
}
