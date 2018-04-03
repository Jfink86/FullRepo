using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " ";

            Client client = new Client();
            Checking check = new Checking();
            Saving saving = new Saving();
            check.Balance = 500.00;
            check.Deposit = 500.00;
            do
            {


                Console.WriteLine("Bitcoin Banker Name : " + client.ClientInfo());
                Console.WriteLine("Encripted ID Number : " + client.AccNum());
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("<<CHECKING ACCOUNT # 985***65**722>>");
                Console.WriteLine();
                Console.WriteLine("1. VIEW BALANCE.....:" + check.Bal());
                Console.WriteLine("2. DEPOSIT..........:");
                Console.WriteLine("3. WITHDRAW.........:");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("<<SAVINGS ACCOUNT # 306***96**745>>");
                Console.WriteLine();
                Console.WriteLine("4. VIEW BALANCE......:");
                Console.WriteLine("5. DEPOSIT FUNDS.....:");
                Console.WriteLine("6. WITHDRAW FUNDS....:");
                Console.WriteLine();
                Console.WriteLine("7. exit");

                input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                        Console.WriteLine(check.Bal());
                        break;
                    case "2":

                        Console.WriteLine(check.Dep());
                        break;
                    case "3":
                        Console.WriteLine(check.Wthdrw());
                        break;
                    case "4":
                        Console.WriteLine(saving.Bal());
                        break;
                    case "5":
                        Console.WriteLine(saving.Dep());
                        break;
                    case "6":
                        Console.WriteLine(saving.Wthdrw());
                        break;
                }


            } while (true);









        }

    }
}
