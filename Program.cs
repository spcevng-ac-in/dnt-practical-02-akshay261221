using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, wg, charge;
            Console.WriteLine("Enter the value of km");
            km = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of wg");
            wg = int.Parse(Console.ReadLine());

            if (km <= 100)
            {
                charge = 50*wg;
            }
            else if (km >= 100 && km <= 200)
            {
                charge = 65*wg;
            }
            else if (km >= 200 && km <= 300)
            {
                charge = 90*wg;
            }
            
            else
            {
                charge= 120*wg;
            }

            Console.WriteLine("charges=" + charge);
                Console.ReadLine();

        }
    }
}
