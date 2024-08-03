using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("int1 " + i);
            }
            
            for (int i2 = 0; i2 <= 10; i2 += 2)
            {
                Console.WriteLine("int2 " + i2);
            }
            Console.ReadLine();
        }
    }
}
