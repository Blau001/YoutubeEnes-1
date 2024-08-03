using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ahmet", "Mehmet", "Ali", "Veli" };
            //double[] ondalıklıSayilar = new double[] {7.5, 3.2, 10.0, 4.6};
            char[] karakterler = new char[] { 'a', 'b', 'c', 'd' };
            for ( int i= 0; i< karakterler.Length; i++)
            {
                Console.WriteLine(karakterler[2]);
            }
        }
    }
}
