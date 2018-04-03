using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int jackpotAmount = 66888;
            int j;

            string action = "  ";
            do
            {

                Console.WriteLine("Welcome to the Range Setter Lucky Lotto Game");

                Console.ReadLine();

                Console.WriteLine("Range Setter is the only lotto game that lets you set the range");

                Console.ReadLine();

                Console.WriteLine("First Select a starting then an ending number to set the Range");

                Console.ReadLine();

                Console.WriteLine("Next select 6 Lucky Numbers");

                Console.ReadLine();

                Console.WriteLine("If your 6 Lucky Numbers match the 6 six Jackpot Numbers You Win Todays Jackpot");

                Console.ReadLine();

                Console.WriteLine("Todays winning Jackpot is" + jackpotAmount);

                Console.ReadLine();

                Console.WriteLine("Enter your starting number");
                int startNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your ending number");
                int endNumber = int.Parse(Console.ReadLine());

                int[] luckyNumber = new int[6];

                for (i = 0; i < luckyNumber.Length; i++)
                {
                    Console.WriteLine("enter a  lucky number");
                    luckyNumber[i] = int.Parse(Console.ReadLine());


                    if ((luckyNumber[i] < startNumber) || (luckyNumber[i] > endNumber))
                    {
                        Console.WriteLine("Invalid Entery: The number you entered was outside the range");
                        Console.WriteLine("enter an number");
                        luckyNumber[i] = int.Parse(Console.ReadLine());
                    }


                }

                //Console.ReadLine();

                Console.WriteLine("Your Lucky Numebers are:" + luckyNumber[0] + "," + luckyNumber[1] + "," + luckyNumber[2] + "," + luckyNumber[3] + "," + luckyNumber[4] + "," + luckyNumber[5]);

                //Console.ReadLine();

                Console.WriteLine("AND The Winning Jackpot Numbers are.....");

                Console.ReadLine();
                int matchingNumber = 0;
                Random win = new Random();
                int[] jackpotNumbers = new int[6];
                int[] doubNum= new int[6];
               
                for (i = 0; i < jackpotNumbers.Length; i++)
                {
                    jackpotNumbers[i] = win.Next(startNumber, endNumber);
                    Console.WriteLine("Jackpot Numbers" + ":" + jackpotNumbers[i]);
                 
                        {
                           int jack = jackpotNumbers[i];
                        }
                }

                for (i = 0; i < jackpotNumbers.Length; i++)
                {
                    for (j = 0; j < luckyNumber.Length; j++)
                    {
                        if (luckyNumber[j] == jackpotNumbers[i])
                        {
                            matchingNumber += 1;
                        }
                    }
                }

                int currentBitcoin = 11148;
                int winningAmount;
                winningAmount = currentBitcoin * matchingNumber;

                Console.ReadLine();

                Console.WriteLine("Congratualtion you matched " + matchingNumber + " numbers correctly");

                Console.ReadLine();

                Console.WriteLine("YOU WON $" + winningAmount);

                Console.ReadLine();

                Console.WriteLine("type Yes to play again or type No to exit");

                action = Console.ReadLine();

             
            } while (action != "no")
            ;
                {
                    Console.WriteLine("Thanks for Playing");
                }

            

       
            
        }

    }

} 

  






