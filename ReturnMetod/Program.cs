using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Donendeger = ToplamaYap(5, 6);
            //if (Donendeger > 10)
            //{
            //    Console.WriteLine("10'dan buyuk");
            //}
            //else
            //{
            //    Console.WriteLine("10'dan kucuk");
            //}
           // İsimSoyisimDondur("Ahmet", "Mehmet");
            //Console.WriteLine(İsimSoyisimDondur("Ahmet", "Mehmet"));
            string gelenİsimSoyisim = İsimSoyisimDondur("Ahmet", "Mehmet");
            Console.WriteLine(gelenİsimSoyisim);
            Console.ReadLine();
        }

        static int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static string İsimSoyisimDondur(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }
    }
}
