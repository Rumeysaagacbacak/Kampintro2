using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Rümeysa";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Eğitmen = "Rümeysa Agacbacak";
            kurs1.IzlenmeOrani = 92;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Eğitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pythıon";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 86;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Eğitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs.Eğitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : " + kurs.Eğitmen);

            }
            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
