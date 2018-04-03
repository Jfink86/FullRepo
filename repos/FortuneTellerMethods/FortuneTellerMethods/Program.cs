using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            //added FullNmae method
            Console.WriteLine("Greetings, "+  + ". I will tell you your fortune!");
            Program joe = new Program();

            joe.FullName();

            
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            int retire = 0;

            if ((age % 2 == 0))

            { retire = (10); }

            else

            { retire = (30); }

            Console.WriteLine("You will retire in " + RetireAge(age, retire));
                
            Console.WriteLine("Please tell me the month that you were born using a number?");
            double birthMonth = double.Parse(Console.ReadLine());

            int moneyOne = 500000000;
            int moneyTwo = 10000;
            int moneyThree = 100000000;
            double moneyFour = 0.00;


            if (birthMonth <= 4)

            { birthMonth = moneyOne; }

            else if ((birthMonth > 4) && (birthMonth <= 9))

            { birthMonth = moneyTwo; }

            else if ((birthMonth > 9) && (birthMonth <= 12))

            { birthMonth = moneyThree; }

            else birthMonth = moneyFour;

            Console.WriteLine("Now tell your favorite color using ROYBIV? If you are unsure simply type help.");
            string color = Console.ReadLine();

            string trans = "";

            switch (color)
            {
                case "red":
                    trans = ("car");
                    break;

                case "orange":
                    trans = ("truck");
                    break;
                case "yellow":
                    trans = ("van");
                    break;
                case "green":
                    trans = ("bus");
                    break;
                case "blue":
                    trans = ("Lamborgini");
                    break;
                case "indigo":
                    trans = ("boat");
                    break;
                case "violet":
                    trans = ("bike");
                    break;
                case "help":
                    Console.WriteLine(trans = ("Help menu ROYGBIV: red,orange,yellow,green,blue,indigo and violet"));
                    Console.WriteLine();
                    Console.WriteLine("Now tell your favorite color using ROYBIV? If you are unsure simply type help.");
                    color = Console.ReadLine();
                    break;
                default:
                    trans = "matchbox";
                    break;
            }

            Console.WriteLine("Lastly how many siblings do you have?");
            int sibling = int.Parse(Console.ReadLine());
            
            string vacaHome = "";

            string vacaOne = "Fiji";
            string vacaTwo = "italy";
            string vacaThree = "greece";
            string vacaFour = "moms basement";
            string vacaFive = "canada";

            if (sibling == 3)

            { vacaHome = vacaOne; }

            else if (sibling == 2)

            { vacaHome = vacaTwo; }

            if (sibling == 1)

            { vacaHome = vacaThree; }

            if (sibling <= 0)

            { vacaHome = vacaFour; }

            if (sibling >= 4)
            { vacaHome = vacaFive; }

            // Sibling and vacation home using new method
            Console.WriteLine( "you will retire in" + VacaSib);


            Console.WriteLine(firstName + lastName + " will retire in " + retire + " years, with $" + birthMonth + " in the bank, a vacation home in "
                + vacaHome + " and a " + trans + ".");


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        static string FullName(string firstName,string lastName)
        {
            string greeting = firstName + lastName;
            return greeting;
        }
         /// <summary>
         /// 
         /// </summary>
         /// <param name="age"></param>
         /// <param name="retire"></param>
         /// <returns></returns>
        static int RetireAge(int age)
        {
            if (age % 2 == 0)
            {
                return 15;
            }
            else
            {
                return 25;
            }
        }
        


        static string VacaSib(int sibling)
        {
            if (sibling == 0)
            {
                return "London, England";
            }
            else if (sibling == 1)
            {
                return "Jamaca";
            }
            else
            {
                return "goo";
            }   
            

        }









    }
}
