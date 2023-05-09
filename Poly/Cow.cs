using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    class Cow: Animal
    {
        public double amtMilk;
        public Cow(int id, double amtMilk) : base(id)
        {
            this.amtMilk=amtMilk;
        }
        
        override public double getProf()
        {
            return (5.0);
        }
        
        
    }
}
