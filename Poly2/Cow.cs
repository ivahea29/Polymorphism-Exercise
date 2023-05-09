using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyAndInheriatanceTask
{ 
    class Cow: Animals; // subclass
    {
        public double amtMilk;
        public Cow(int id, double amtMilk) : base(id)
        { 
            this.amtMilk = amtMilk; 
        }
        override public double getProf() // override method
        {
            return (5.0);
        }
        
    }
}
