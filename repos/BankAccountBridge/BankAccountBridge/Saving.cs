using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridge
{
    class Saving : Account
    {
        // Inherited Fields or Instant variables
        private double saveBal = 239568.65;
            
       // Inherited Properties

        // Constructor

        public Saving()
        {

        }

        public Saving(double saveBal, double saveDep, double saveWthdrw)
        {
            this.Balance = saveBal;
            this.Deposit = saveDep;
            this.Withdraw = saveWthdrw;
        }

        // Methods

        public override double Bal()
        {
            return Balance;
        }

        public override double Dep()
        {
            return Deposit;
        }

        public override double Wthdrw()
        {
            return Withdraw; 
        }


    }
}
