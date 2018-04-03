using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public abstract class Travel
    {   
        // Feilds

        string eyeColor = Console.ReadLine();
        string input;
        double inputValue;
        // Properties

        public string EyeColor { get; set; }
        public string Input { get; set; }
        public double InoutValue { get; set; }
        //Constructors

        public Travel()
        {
            // Default
        }

        public Travel(string eyeColor)


        {

        }

        // Method

        public  void Destination()
        {
            if (input == eyeColor)
            {
                inputValue = 1;
            }
            if (input == eyeColor)
            {
                inputValue = 2;
            }   
            if( input == eyeColor)
            {
                inputValue = 3;
            }    
            if (input == eyeColor)
            {
                inputValue = 4;
            }
            else
            {
                return ; 
            }


        }
        

        








    }
}

