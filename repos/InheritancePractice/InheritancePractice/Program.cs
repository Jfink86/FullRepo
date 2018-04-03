using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {

        static void Main(string[] args)
        
        // fields

        private int windows;
        private int doors;
        private int roof;
        private int siding;

        // properties

        public int Windows
        {
            get { return this.windows; }
            set { this.windows = value; }
        }

        public int Doors
        {
            get { return this.doors; }
            set { this.doors = value; }
        }
         
        public int Roof
        {
            get { return this.roof; }
            set { this.roof = value; }
        }

        public int Siding
         {
            get { return this.siding; }
            set { this.siding = value; }
        }

        /// Constructors

        public House()
        {
            // default
        }

        public House(int windows, int doors, int roof, int siding)
        {
            this.windows = windows;
            this.doors = doors;
            this.roof = roof;
            this.siding = siding;
        }
        
        // add methods

            
        

        

        
    }
}
