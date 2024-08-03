using System;

namespace CarpimTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çarpım Tablosu\n");

            // Sütun başlıklarını yazdır
            Console.Write("\t");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            // Çarpım tablosunu yazdır
            for (int i = 1; i <= 10; i++)
            {
                // Satır başlıklarını yazdır
                Console.Write(i + "\t");

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); // Konsolu açık tutmak için kullanıcıdan giriş bekle
        }
    }
}
