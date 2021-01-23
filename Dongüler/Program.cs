using System;

namespace Dongüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Yetiştirme Kampı";
            string kurs2 = "Programlama başlangıç için temel kurs";
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Yetiştirme Kampı", "Programlama başlangıç için temel kurs","Java","python",
            "C++"};
                

            for (int i = 0; i <kurslar.Length; i++) //length eleman sayısı 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti.");

            foreach (string kurs in kurslar) //dizilere uygulanır .diziler tek tek sorguluyor.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
