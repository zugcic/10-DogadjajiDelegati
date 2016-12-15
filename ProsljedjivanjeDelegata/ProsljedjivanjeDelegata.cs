using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    // primjer programa s delegatima
    
    public class ProsljedjivanjeDelegata
    {
        // definicija delegata
        delegate double Funkcija(double x);

        // metoda koja prihvaća delegata
        static void IspišiFunkciju(Funkcija fja, double x1, double x2, int n)
        {
            Console.WriteLine("Ispis funkcije {0}:", fja.Method);
            Console.WriteLine("{0} {1}", "x", "y");
            for (int i = 0; i < n; ++i)
            {
                double x = x1 + (x2 - x1) / (n - 1) * i;
                Console.WriteLine("{0} {1}", x, fja(x));
            }
        }

        public static void IspisFunkcijeSinus()
        {
			//  Pozvati metodu IspišiFunkciju tako da ispiše vrijednosti funkcije Math.Sin za 10 točaka u intervalu od 0 do Math.PI
			Funkcija f = new Funkcija(Math.Sin);
			IspišiFunkciju(f, 0, Math.PI, 10);
        }

        public static void IspisFunkcijeE()
        {
			//  Pozvati metodu IspišiFunkciju tako da ispiše vrijednosti funkcije Math.Exp za 5 točaka u intervalu od 0 do 10
			IspišiFunkciju(Math.Exp, 0, 10, 5);
		}

        static void Main(string[] args)
        {
            IspisFunkcijeSinus();

            IspisFunkcijeE();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
