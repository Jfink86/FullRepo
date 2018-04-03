
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridge
{
    public class Client
    {
        //  Fields

        private string firstName = "Joe";
        private string lastName = "Fink";
        private int accountNum = 2_8_2018_420; //Date+Time

        // Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccountNum { get; set; }

        // Constructor

        public Client()
        {

        }


        public Client( string firstName, string lastName, int accountNum)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AccountNum = accountNum;
        }
       
        //  Methods

        public string ClientInfo()
        {
            return  firstName + lastName;
        }

        public int AccNum()
        {
            return accountNum;
        }





    }

}
