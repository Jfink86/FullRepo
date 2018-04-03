using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    public class Memebership
    { 
         // Fields
      
        private int memberID;
        private bool isActive;


        // Proprerties

        public int MemberID
        {
            get { return this.memberID; }
            set { this.memberID = value; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }

        // Constructor

        public Memebership()
        {
            //default
        }

       
        public Memebership(bool isActive) //Over loaded constructor with two perimeters 
        { //this.field  || this.perimeter  
            this.memberID = memberID;
            this.isActive = isActive;
        }

        // Method Virtual would be a method() in the base class

        public virtual void Activate()
        {
            if (isActive == false) // Checking for equality with ==
            {
                isActive = true; // If false then turn into true
                Console.WriteLine("Your membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your membership is already active");
            }
        }






    }

           
}
