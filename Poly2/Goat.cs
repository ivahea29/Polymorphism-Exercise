using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyAndInheriatanceTask
{
    class Goat: Animals // Subclass
    {
        public double amtMilk;
        public Goat(int id, double amtMilk) : base(id)
        {
            this.amtMilk = amtMilk; 
        } 
        override public double getProf() // override method
        {
            double sum = 0;
            return (sum);
        }
        
    }
}
