using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beden Kitle Endeksi Hesaplayıcı");
            Console.WriteLine("Lütfen boyunuzu (metre cinsinden) giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen kilonuzu giriniz:");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen yasınızı giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());
            double endeks = kilo / (boy * boy);
            Console.WriteLine("Vücut kitle endeksiniz: " + endeks);
            if (endeks < 18.5)
            {
                Console.WriteLine("Zayıf");
            }
            else if (endeks >= 18.5 && endeks < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (endeks >= 25 && endeks < 30)
            {
                Console.WriteLine("Fazla Kilolu");
            }
            else
            {
                Console.WriteLine("Obez");
            }
            Console.ReadLine();
        }
    }
}
