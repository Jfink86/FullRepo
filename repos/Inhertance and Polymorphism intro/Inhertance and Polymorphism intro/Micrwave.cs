using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    public class Micrwave : ApplianceClass
    {
        //Fields
        private int watts;
        private string brand;

        //properties
        public int Watts
        {
            get { return this.watts; }
            set { this.watts = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        //constructors
        public Micrwave()
        {
            //default
        }

        public Micrwave(int watts, string brand)
        {
            this.watts = watts;
            this.brand = brand;
        }

        //  methods
        public override void Work()
        {
            Console.WriteLine("I emmit radioactive waves");
            Console.WriteLine("i heat up food");
        }



    }

}
