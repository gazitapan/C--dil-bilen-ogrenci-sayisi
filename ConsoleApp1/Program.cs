using System;

namespace dilBilenOgr
{
    class Program
    {
        static void Main(string[] args)
        {
            int ogrSayi = 5;
            int ingilizceBilenler = 0;
            int almancaBilenler = 0;
            int fransızcaBilenler = 0;
            Console.WriteLine("İngilizce için 1");
            Console.WriteLine("Almanca için 2");
            Console.WriteLine("Fransızca için 3");
            for (int i = 0; i < ogrSayi; i++)
            {
                Console.WriteLine($"{i + 1}. Öğrenci hangi yabancı dil dersini almaktadır:");
                string ders = Console.ReadLine().ToLowerInvariant();
                if (ders == "1")
                    ingilizceBilenler++;
                else if (ders == "2")
                    almancaBilenler++;
                else if (ders == "3")
                    fransızcaBilenler++;
            }
            Console.Clear();
            Console.WriteLine($"İngilizce Bilen Sayısı = {ingilizceBilenler}");
            Console.WriteLine($"Almanca Bilen Sayısı = {almancaBilenler}");
            Console.WriteLine($"Fransızca Bilen Sayısı = {fransızcaBilenler}");
            Console.ReadKey();
        }
    }
}
