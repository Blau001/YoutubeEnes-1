using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayTekMiCiftMi
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz: ");
            int Sonuc = Convert.ToInt32(Console.ReadLine());
            CiftMi(Sonuc);
            Console.ReadLine();
        }
        static int CiftMi(int sayi)
        {
            sayi = sayi % 2;
            
            if (sayi == 0)
            { Console.WriteLine("Çift"); }
            else
            { Console.WriteLine("Tek"); }
            return sayi;
        }
    }
}
