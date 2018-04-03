using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            do
            {



                Console.WriteLine(" Hello welcome to the fridge app");
                Console.WriteLine(" What would you like to do with your fridge");
                Console.WriteLine("To dispense water, Type 1");
                Console.WriteLine("To change light bulb Type 2");
                Console.WriteLine(" To clean Type 3");
                Console.WriteLine("To take food Type 4");
                Console.WriteLine("To check food supply Type 5");
                Console.WriteLine("To see all fridge details Type 6");
                Console.WriteLine("To restart, Type 7");
                Console.WriteLine("To quit, Type 8");

                userChoice = int.Parse(Console.ReadLine());

                Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);

                switch (userChoice)
                {
                    case 1:
                        userFridge.DisWater();
                        break;
                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;
                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;
                    case 4:
                        Console.WriteLine("would you like to somegthing to eat?");
                        int removefood = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(removefood);
                        break;
                    case 5:
                        Console.WriteLine("Do you have any food");
                    

                }
           
                
                    
                

            } while (userChoice!= 8);
                
        }

    }
}
