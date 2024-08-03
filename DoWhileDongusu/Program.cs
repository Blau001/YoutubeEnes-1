using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a =0;
            int toplam = 0;
           
            do
            {
                Console.WriteLine("Bir önceki sayı ile toplamı, karşısına yazılmıştır.");
                Console.WriteLine( a + " = " + toplam);
                toplam += a;
                a++;
                

            }
            while (a <= 100);
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadLine();
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i<10);
            //Console.WriteLine(i);
            //Console.ReadLine();
        }
    }
}
