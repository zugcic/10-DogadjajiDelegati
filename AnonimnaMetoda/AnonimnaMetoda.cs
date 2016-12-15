﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Vsite.CSharp
{
    class Program
    {
        delegate void Metoda(int a);

        const int max = 1000;
        const string format = "{0, 7} ";

       

        static void Main(string[] args)
        {
			//Thread nit = new Thread(NitnaMetoda);
			Thread nit = new Thread(() =>
			{
				Console.WriteLine("Krenula je nova nit...");
				for (int i = 0; i < max; ++i)
				{
					Console.Write(format, i);
				}
			}
			);
			//Umjesto gornje naredbe u kojoj se prosljeđuje NitnaMetoda, novoj niti proslijediti anonimnu metodu definiranu pomoću delegata


			nit.Start();

            for (int i = 0; i < max; ++i)
            {
                Console.Write(format, -i);
            }

            Console.WriteLine("Čekam nit");
            nit.Join(); // čeka dodatnu nit da završi s izvođenjem

            Console.WriteLine();
            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
