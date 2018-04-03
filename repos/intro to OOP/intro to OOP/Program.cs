using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_to_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.eat();

            secondCat.Meow();



        }
    }
}
