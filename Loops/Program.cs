using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"yazılım", "borsa" , "dil"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                
            }
            Console.WriteLine("sayfasonu");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
