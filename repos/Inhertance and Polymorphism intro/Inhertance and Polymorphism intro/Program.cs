using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polymorphism_intro
{
    class Program
    {
        static void Main(string[] args)
        {

            Micrwave myMicrowave = new Micrwave(1000, "samsung");
            Dishwasher myDishwasher = new Dishwasher(0, true);

            myMicrowave.Work();
            myDishwasher.Work();






        }
    }
}
