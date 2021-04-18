using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdı = "yazılım";
            kurs1.Eğitmen = "rahmi";
            kurs1.İzlenmeOranı = 23;

            kurs kurs2 = new kurs();
            kurs2.KursAdı = "borsam";
            kurs2.Eğitmen = "anan";
            kurs2.İzlenmeOranı = 234;

            kurs kurs3 = new kurs();
            kurs3.KursAdı = "yemek";
            kurs3.Eğitmen = "ben";
            kurs3.İzlenmeOranı = 3;
            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };
            foreach (kurs Kurslar in kurslar)
            {
                Console.WriteLine(Kurslar.Eğitmen + "  " + Kurslar.KursAdı);
            }
        }
        
	

	
    }
    class kurs
    {
        public string KursAdı { get; set; }
        public string Eğitmen { get; set; }
        public int İzlenmeOranı { get; set; }

    }
}
