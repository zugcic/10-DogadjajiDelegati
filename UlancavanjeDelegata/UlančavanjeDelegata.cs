using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Vsite.CSharp
{
    public class UlančavanjeDelegata
    {
        delegate void IspišiPoruku(string poruka);

        // dvije metode koje možemo pridružiti delegatu
        private static void IspišiNaKonzolu(string poruka)
        {
            Console.WriteLine(poruka);
        }

        private static void IspišiUFajl(string poruka)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream("poruke.txt", FileMode.Append, FileAccess.Write)))
                writer.WriteLine(poruka);
        }

        public static void IspisPoruka(params string[] poruke)
        {
            IspišiPoruku ip = IspišiUFajl;

            ip(poruke[0]);

			// Nadovežite u delegatsku listu metodu IspišiNaKonzolu. Pokrenite program i usporedite prikaz na konzoli sa sadržajem datoteke "poruke.txt"
			ip += IspišiNaKonzolu;

            ip(poruke[1]);

        }

        static void Main(string[] args)
        {
            IspisPoruka("Dobar dan", "Bok");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
