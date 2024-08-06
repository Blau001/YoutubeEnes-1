using System;

namespace KullanıcıdanAlınanDegerlerleIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 adet int değer alınacak
            int[] sayilar = new int[10];
            int tekMi = 0;
            int tekToplam = 0;
            int ciftMi = 0;
            int ciftToplam = 0;

            // Kullanıcıdan değerleri alma
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz: ");
                int kullanıcıdeger = int.Parse(Console.ReadLine());
                sayilar[i] = kullanıcıdeger;
            }

            // Tek ve çift sayıları bulma
            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftMi++;
                    ciftToplam += sayilar[j];
                }
                else
                {
                    tekMi++;
                    tekToplam += sayilar[j];
                }
            }

            // Sonuçları gösterme
            Console.WriteLine("**************************");
            Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);
            Console.WriteLine("Çift sayıların adedi: " + ciftMi);
            Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("Tek sayıların adedi: " + tekMi);
            Console.WriteLine("**************************");

            // Hangi toplamın daha büyük olduğunu gösterme
            if (ciftToplam > tekToplam)
            {
                Console.WriteLine("Çift sayıların toplamı, tek sayıların toplamından büyüktür.");
            }
            else if (tekToplam > ciftToplam)
            {
                Console.WriteLine("Tek sayıların toplamı, çift sayıların toplamından büyüktür.");
            }
            else
            {
                Console.WriteLine("Tek ve çift sayıların toplamları eşittir.");
            }

            Console.ReadLine();
        }
    }
}
