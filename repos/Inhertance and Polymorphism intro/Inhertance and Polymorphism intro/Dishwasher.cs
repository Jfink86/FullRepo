using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    public class Dishwasher : ApplianceClass
    {
        //Fields
        //invisible

        //Properties
        public double DecibleLevel { get; set; }
        public bool HasHeatDry { get; set; }
        //constructors
        public Dishwasher()
        {
            //default constructor
        }

        public Dishwasher(double decibleLevel, bool hasHeatDry)
        {
            DecibleLevel = decibleLevel;
            HasHeatDry = hasHeatDry;
        }

        //  Methods
        public override void Work()
        {
            Console.WriteLine("i wash your dishes");
            Console.WriteLine("wash wash wash");
        }













    }
}
