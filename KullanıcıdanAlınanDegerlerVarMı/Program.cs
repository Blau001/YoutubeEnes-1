using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıdanAlınanDegerlerVarMı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,10,10 };
            int adet = 0;
            int sayi;
            Console.WriteLine("Bir sayı giriniz.");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("Girdiğiniz sayı mevcut değildir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı mevcuttur.");
                Console.WriteLine("Girdiğiniz sayı mevcuttur. " + adet + " kez tekrarlandı.");
            }
        }
    }
}

