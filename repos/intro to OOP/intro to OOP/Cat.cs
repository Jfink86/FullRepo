using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_to_OOP
{
    class Cat
    {
        //I need STATES
        //Fields
        private string name;
        private int age;
        private string forColor;
        private bool isHungry = true;

        //Properties
        public string Name// change field name to Pascal case; name to Name
        {
            get { return this.name; }//.this is used to be specific
            set { this.name = value; }
        }

        //I need BEHAVIORS
        //Constructors
        public Cat()
        {
            //default constructor
            //takes no parameters(nothing in parentheses)

        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.forColor = furColor;
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("is the cat hungry?" + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }

        private Dog
    {
 
        private string hairLength;
        private double height;
        private int runningSpeed;
        private double weight;
        private Dog()
        {
            this.run = run;
            this.bark = bark;
            this.potty = potty;
            this.cuddle = cuddle;
        }
    }
}



    


}
