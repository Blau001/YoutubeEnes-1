using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıdanSayıAl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı giriniz.");
            int sayi =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayı : " + sayi);
            int toplam = 0;
            for (int i = 0; i <sayi; i++ )
            {
                toplam += i;
            }
            double ort = toplam / sayi;

            if (ort > 50)
            { Console.WriteLine("Ortalama sayınız: " + ort + " Ortlamanız 50'den büyük "); }
            else if (ort >= 50)
            { Console.WriteLine("Ortalama sayınız: " + ort + " Ortlamanız 50'ye eşittir. "); }
            else
            { Console.WriteLine("Ortalama sayınız: " + ort + " Ortlamanız 50'den küçük "); }
        }
    }
}
