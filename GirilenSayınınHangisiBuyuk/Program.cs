using System;

namespace GirilenSayininHangisiBuyuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İlk sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int buyukSayi = kontrolEt(x, y);
            Console.WriteLine("Büyük sayı: " + buyukSayi);

            Console.ReadLine();
        }

        static int kontrolEt(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("İlk sayı ikinci sayıdan büyüktür.");
                return x;
            }
            else if (x < y)
            {
                Console.WriteLine("İkinci sayı ilk sayıdan büyüktür.");
                return y;
            }
            else
            {
                Console.WriteLine("İki sayı da eşittir.");
                return x; // Ya da return y; fark etmez çünkü eşitler.
            }
        }
    }
}
