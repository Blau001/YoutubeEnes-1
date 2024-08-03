using System;

namespace IcIceForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı giriniz: ");
            string isim = Console.ReadLine();
            int uzunluk = isim.Length;

            for (int i = 0; i < uzunluk; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(isim.Substring(0, j + 1) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
