using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int CebimdekiPara = 0;
            int param = 12;
            if (CebimdekiPara>param)
            {
                Console.WriteLine("bankaya at");
            }
            else if (param > CebimdekiPara)
            {
                Console.WriteLine("para çek");
            }
            else
            {
                Console.WriteLine("biriktir");
            }
                     
            bool SistemGirisi = false;
            if (SistemGirisi == true )
            {
                Console.WriteLine("hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("giriş yapınız");
            }
        }
    }
}
