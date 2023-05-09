using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    class JersyCow: Cow
    {
        public JersyCow(int id, double amtMilk): base(id,amtMilk) {; }
        
        override public double getProf() {
            double sum = 21.5* 3;
            return (sum);
        }
        
    }
}
