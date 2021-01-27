using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Geliştirme Kursu";
            string kurs4 = "Python Kursu";
            string kurs5 = "C# Kursu";
            
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            
            Console.WriteLine("--------------------------------------------------------------------------------------------------");


            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java Geliştirme Kursu", "Python Kursu","C# Kursu"};



            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            
            
            foreach (var kurs in kurslar)
            {

                Console.WriteLine(kurs);

            }        }
    }
}
