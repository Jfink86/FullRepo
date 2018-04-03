using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Lotto_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a game and Todays winning Jackpot is One MILLION Dollars!");

            Console.ReadLine();

            Console.WriteLine("Enter starting number");
            int startNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("enter ending number");
            int endNumber = int.Parse(Console.ReadLine());

            //int  = 0;
            //int luckyNumber[i] = 0;
            //int i = 0;

            int[] luckyNumber = new int[6];

            for (int i = 0; i < luckyNumber.Length; i++)
            {
                //int userNumber = 0;
                Console.WriteLine("enter a  lucky number");
                luckyNumber[i] = int.Parse(Console.ReadLine());

            }
            if ((luckyNumber[i] < startNumber) && (luckyNumber[i] > endNumber))
            {
                Console.WriteLine("Invalid Entery: The number you entered was outside the range");
            }

            Console.WriteLine("Your Lucky numebers are:" + luckyNumber[0] + "," + luckyNumber[1] + "," + luckyNumber[2] + "," + luckyNumber[3] + "," + luckyNumber[4] + "," + luckyNumber[5]);

            Console.ReadLine();

            Random win = new Random();
            int[] jackpotNumbers = new int[6];

            for (int i = 0; i < jackpotNumbers.Length; i++)

            {
                jackpotNumbers[i] = win.Next(startNumber, endNumber);
                Console.WriteLine("Jackpot Numbers" + ":" + jackpotNumbers[i]);
            }

            //int JackpotAmount = 1000000;


            //if (jackpotNumbers[i] == luckyNumber[i])

        }
    }
}
