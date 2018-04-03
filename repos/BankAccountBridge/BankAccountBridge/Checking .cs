using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridge
{
    public class  Checking : Account
    {
        // Inherited Fields or Instant variables
        
        // Inherited Properties

        // Constructor

        public Checking()
        {
            // Default
        }

        public Checking(double checkBal, double checkDep, double checkWthdrw)
        {
            this.Balance = checkBal;
            this.Deposit = checkDep;
            this.Withdraw  = checkWthdrw;
        }

        // Method

        

        




    }

}
