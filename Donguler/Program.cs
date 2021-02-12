using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python", "Javascript", "C++", "C#" };

            Console.WriteLine("For Döngüsü");
            Console.WriteLine("------------------------");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + kurslar[i]);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("ForEach Döngüsü");
            Console.WriteLine("------------------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
                Console.WriteLine("------------------------");
            }
        }
    }
}
