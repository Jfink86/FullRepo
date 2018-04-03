using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancianting a new dictionary 
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                { "Kerry", 90},  // in this case name=key and #=value
                { "Barry", 85},
                { "Michelle", 100}
            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" }, //A1=key Candy=value
                {"A2", "Golgfish" },
                {"A3","Sour Patch" },
                {"A4", "Funyuns" }
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //Add metthod
            // this machine uses just a number not letter/number
            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Coke");
            drinkMachine.Add(12, "Pepsi");
            drinkMachine.Add(13, "Sprite");
            drinkMachine.Add(14, "Root beer");
            drinkMachine.Add(15, "Budweiser");

            //Count is a property not a method returns the size 
            Console.WriteLine(drinkMachine.Count);

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }


            //create dic with number as key and coat as value
            Dictionary<int,string> coatCheck = new Dictionary<int, string>();//<--semi; mat the end!!!

            {
                coatCheck.Add(1,"leather bomber");
                coatCheck.Add(2, "Pea coat");
                coatCheck.Add(3, "ski jacket");
                coatCheck.Add(4, "over coat");
                coatCheck.Add(5, "rain coat");
                coatCheck.Add(6, "Suit coat");
            }

            foreach(KeyValuePair<int,String> coat in coatCheck)
            {
                Console.WriteLine(coat.Value);
            }

            // create dic for cars in valet service 
            // key- last name //value-car model
            //print all KEYS

            Dictionary<string, string> valet = new Dictionary<string, string>()
            {
                {"Thomas", "cadilac" },
                { "Fink", "BMV"},
                {"Linich","Nissan" },
                {"Lucas", "Maxima" },  //<---comma
                { "Kaleal", "F-150" }  //<---no-comma on last 
            };//<-----semi goes here      

            foreach (KeyValuePair<string,string> lastNames in valet)

            {
                Console.WriteLine(lastNames.Key);//<-- lastNames and Key being called 
            }




            

        }

    }
}
