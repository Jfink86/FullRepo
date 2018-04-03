using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    public abstract class ApplianceClass
    {
        //Fields
        private bool isElectric;

        //Properties
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        //constructors

        //Method
        public abstract void Work()
        {

        }







    }


}
