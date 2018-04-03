using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_example
{
    class Fridge
    {
        static void Main(string[] args)
        {






            //creat an interactive console window
            //prompt user to choose what to do with the fridge
            //call methods on the fridge object to do what the user wants
            int userChoice;
            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);
            //int newFoodAmount;
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, press 1");
                Console.WriteLine("To change lightbulb, press 2");
                Console.WriteLine("To clean, type 3");
                Console.WriteLine("To take food, type 4");
                Console.WriteLine("To check food, type 5");
                Console.WriteLine("To see all fridge details, type 6");
                Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit,type 8");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;
                    //void method, with a consolewriteline in the fridge class
                    case 2:
                        string bulbString = userFridge.ChangeBulbs();
                        Console.WriteLine(bulbString);
                        //or you can write it as Console.WriteLine(userFridge.ChangeBulbs());
                        //potentially better option since we wont user string again.
                        // string method, returns string and we need to accomodate the return in our program class.
                        break;
                    case 3:
                        userFridge.Clean();
                        break;
                    case 4:

                        Console.WriteLine("Your current level is " + userFridge.FoodAmount + "how much do you want to remove?");
                        int foodRemoved = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodRemoved);
                        //newFoodAmount = userFridge.FoodAmount;
                        Console.WriteLine("your new amount is currently: " + userFridge.FoodAmount);
                        break;
                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;
                    case 6:
                        Console.WriteLine("It is " + userFridge.IsClean + " that your fridge is clean. " + " Your fridge has a " + userFridge.DispenserType + ".  Your food amount is " + userFridge.FoodAmount + ".  And it is " + userFridge.BulbsWork + " that your bulbs work.");
                        break;
                    case 7:
                        Console.WriteLine("\nLet's try this again....What would you like to do?");
                        break;
                }
            } while (userChoice != 8);
        }
    }

}