using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyAndInheriatanceTask
{
    class Animals // Super class for the subclasses goat, cow, jersey cow
    {
        public int id;

        public Animals(int id)
        { 
            this.id = id; 
        }
        virtual public double getProf()
        { 
            return (150); 
        }


    }
}
