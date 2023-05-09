using System;

namespace Poly
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal [] myFarm = new Animal[10];
            for (int i=0; i <10; i++)
            {
                if (i <= 5)
                {
                    myFarm[i] = new Cow(i + 100, i * 23.5);
                } else
                {
                    myFarm[i] = new JersyCow(i + 500, i * 100.5);
                }
            } // end of loop
            double tot = 0.0;
            for (int i = 20; i >= 10; i--)
            {
                tot += myFarm[i-11].getProf();
            }
            //Console.WriteLine("The total is: ");
            return;
        } // end of Main
    }
}
