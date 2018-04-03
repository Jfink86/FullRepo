using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Beach:Travel
    {   // Feilds
    
        
        // Properties
        public string EyeColor { get; set; }
        
        //Constructors
        public Beach()
        {
            // Default
        }

        public Beach(string eyeColor)
        {

        }

        // Method
        public void Destination()
        {
            do
            {
                Console.WriteLine("Select your eye color from the following:");

                EyeColor = Console.ReadLine();

                if ( InputValue == 1)
                {
                    Console.WriteLine("Barefoot Beach");
                }
                if (eyeColor == 2)
                {
                    Console.WriteLine("Seista Key");
                }
                if (eyeColor == 3)
                {
                    Console.WriteLine("Fort Fyers Beach");
                }
                if (eyeColor == 4)
                {
                    Console.WriteLine("SantaBelle");
                }
                Console.WriteLine("Press any key to conitue");
                Console.ReadLine();
                Console.Clear();
                
            } while (eyeColor != 5);
            {
                Console.WriteLine("RIGHT NEAR THE BEACH BOYYYY!!!");
                Console.WriteLine();
            }
            return eyeColor;


        }
    }
}
