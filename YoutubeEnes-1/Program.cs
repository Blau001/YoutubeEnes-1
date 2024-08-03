using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeEnes_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk sınav notunuzu giriniz.");
            int ilk = Convert.ToInt32(Console.ReadLine());
            if (ilk > 100)
            {
                Console.WriteLine("GEÇERSİZ NOT GİRİLDİ.");
                Console.WriteLine("TEKRAR DENEYİN.");
                Console.ReadLine();
            }
            Console.WriteLine("İkinci sınav notunuzu giriniz.");
            int ikinci = Convert.ToInt32(Console.ReadLine());
            if (ikinci > 100)
            {
                Console.WriteLine("GEÇERSİZ NOT GİRİLDİ.");
                Console.WriteLine("TEKRAR DENEYİN.");
                Console.ReadLine();
            }
            Console.WriteLine("Uç sınav notunuzu giriniz.");
            int uc = Convert.ToInt32(Console.ReadLine());
            if (uc > 100)
            {
                Console.WriteLine("GEÇERSİZ NOT GİRİLDİ.");
                Console.WriteLine("TEKRAR DENEYİN.");
                Console.ReadLine();
            }
            double ort = (ilk + ikinci + uc) / 3.0;
            Console.WriteLine("Ortalama notunuz : " + ort);
            if (ort > 100)
            {
                Console.WriteLine("GEÇERSİZ NOT GİRİLDİ.");
                Console.WriteLine("TEKRAR DENEYİN.");
                Console.ReadLine();
            }

            else if (ort >= 80 && ort <= 100)
            {
                Console.WriteLine("A Puanı aldınız.");
            }
            else if (ort >= 60)
            {
                Console.WriteLine("B Puanı aldınız.");
            }
            else if (ort >= 40)
            {
                Console.WriteLine("F Puanı aldınız.");
            }
            else
            {
                Console.WriteLine("Kaldınız.");
            }
        }
    }
}
