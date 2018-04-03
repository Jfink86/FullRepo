using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Fridge
    {
        //feilds //camel  //STATES

        private bool isClean;
        private string disType;
        private int foodAmount;
        private bool bulbWorks;

        //Properties // Public Pascal  // get/set camel    //BEHAVIORS

        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }

        public string DisType
        {
            get { return this.disType; }
            set { this.disType = value; }
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public bool BulbWorks
        {
            get { return this.bulbWorks; }
            set { this.bulbWorks = value; }
        }

        //Constructors 

        public Fridge()
        {
            this.disType = "basic water dispenser";
        }

        public Fridge(string disType)
        {
            this.disType = disType;
        }

        public Fridge(bool isClean, string disType, int foodAmount, bool bulbWorks)
        {
            this.isClean = isClean;
            this.disType = disType;
            this.foodAmount = foodAmount;
            this.bulbWorks = bulbWorks;
        }


        //Methods()   // MVP

        public void DisWater()
        {
            if (disType == " basic water dispenser")
            {
                Console.WriteLine("heres some warm water");
            }
            else if (disType == "deluxe dispenser")
            {
                Console.WriteLine("enjoy your perfect water");
            }
            else
            {
                Console.WriteLine("Whats going to come out? Its a surprise!");
            }
       }

        public string ChangeBulbs()
        {
            if (bulbWorks == false)
            {
                bulbWorks = true;
                return "The buld has been changed";
            }
            else
            {
                return "The bulbs dont need to be changed";
            }
        }

        public void RemoveFood(int foodRemoved)
        {
            foodAmount -= foodRemoved;
        }

        public string CheckSupplies()
        {
            if (foodAmount >= 80)
            {
                return "fully stocked";
            }
            else if (foodAmount > 40)
            {
                return "getting low";
            }
            else
            {
                return "Time to shop";
            }
        }

        public string Clean()
        {
            if (isClean == false)
            {
                isClean = true;
                return "I cleaned the fridge";
            }
            else
            {
                return "The fridge is already clean";
            }

        }





    }

}

