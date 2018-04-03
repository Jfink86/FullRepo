using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    public class VIP : Memebership 
    {
        //fields
        //invisible

        //properties
        public bool IsSwanky { get; set; }

        //constructor
        public VIP()
        {
            //default
        }

        public VIP(bool hasSwanky)
        {
            this.IsSwanky = hasSwanky;
        }









    }
}
