using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toyArray = {" action figure, doll, Legos" };

            List<string> toyList = new List<string>() { "action figure", "stuffed animal", "legos" };

            toyList.Add("Barbie");
            toyList.Add("remote control car");
            toyList.Add("Yo-yo");

            foreach (string toy in toyArray) //same as for (int toy = 0; i < toyArray.Length; i++)
            {
                Console.WriteLine(toy);
            }

            //the properties we will use are
            //.Count
            //.Insert()
            //.Add()
            //.Remove()

            Console.WriteLine(toyList.Count);

            toyList.Remove("Barbie");

            Console.WriteLine(toyList.Count);

            toyList.Insert(0, "Kite");
            toyList.Insert(2, "baby doll");
            toyList.Insert(1, "Plastic Dinosaur");

            //>contains()

            foreach (string toy in toyList)
            {
                Console.WriteLine(toy);
            }

            if (toyList.Contains("Plastic Dinosaur"))
            {
                
            }

            //List<bool> shelfStatus = new List<bool>() { true, false, true, true };
            //for (int i = 0; i < shelfStatus.Count; i++)
            //{
            //    if (shelfStatus [i] == true)
            //    {
            //        Console.WriteLine("toys on the shelf");
            //    }
            //    if ( shelfStatus)
            //}
            string[] stuffedArray = { "bear1", "bear2", "bear3", "bear4", "bear5" };
            List<string> stuffAnimal = new List<string>() { "bear1", "bear2", "bear3", "bear4", "bear5" };

            foreach (string stuffAnimal in stuffedArray)
            {

            }












        }
    }
}
