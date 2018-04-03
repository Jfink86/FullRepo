using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    public class StandardMembeship_subClass : Memebership
    {
        //fields
        //invisible

        //properties

        public StandardMembeship_subClass()
        {
            //defaulf constructor
        }

        public StandardMembeship_subClass(int cost)
        {
            cost = cost;
        }

        //methods

        public override void Activate()
        {
            if (IsActive == false)
            {
                IsActive = true;
            }
            else
            {
                Console.WriteLine("your membership hase been activated");
            }


        }









    }
}
