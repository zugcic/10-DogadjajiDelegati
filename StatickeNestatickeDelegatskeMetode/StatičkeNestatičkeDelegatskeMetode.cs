using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    public class StatičkeNestatičkeDelegatskeMetode
    {
        // definicija delegata
        delegate void MojDelegat();

        private static void StatičkaMetoda()
        {
            Console.WriteLine("Pozvana je statička metoda");
        }

        private void MetodaInstance()
        {
            Console.WriteLine("Pozvana je metoda instance");
        }

        public static void PoziviPrekoDelegata()
        {
            // TODO: Instancirati delegata tipa MojDelegat metodom StatičkaMetoda te pozvati delegata

            // TODO: Gornjem delegatu pridružiti metodu MetodaInstance te ponovno pozvati delegata

        }

        static void Main(string[] args)
        {
            PoziviPrekoDelegata();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
