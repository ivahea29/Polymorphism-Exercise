using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyAndInheriatanceTask
{
    class JerseyCow: Cow // Subclass
    {
        public JerseyCow(int id, double amtMilk) : base(id, amtMilk) 
        {
            ; 
        }
        
        override public double getProf() // override method
        {
            double sum = 22.3* 3;
            return (sum);
        }

    }
}
