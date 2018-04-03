using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridge
{
     public abstract class Account
     {
        // fields or instant variables
        // private or protected int acctNum
        // "      "  "        " double balance
        // "        "         " string acctype
        public double balance;
        private double deposit;
        private double withdraw;

        // properties

        public double Balance  { get; set; }
        public double Deposit { get; set; }
        public double Withdraw   { get; set; }

        // Constructor

        public Account()
        {

        }

        public Account(double balance, double deposit, double withdraw)
        {
            this.Balance = balance;
            this.Deposit = deposit;
            this.Withdraw = withdraw;
        }

        // Methods

        public virtual double Bal()
        {
            return Balance;
        } 

        public virtual double Dep()
        {
            return Balance + Deposit;
        }

        public virtual double Wthdrw()
        {
            return balance - withdraw;
        }








     }
}
