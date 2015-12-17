using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // kreiramo objekt koji će generirati alarme
            GeneratorAlarma ga = new GeneratorAlarma();


            Console.WriteLine("Kada stisnemo tipku dići će se alarm, ali prijavljenog slušatelja...");
            Console.ReadKey(true);


            // test: generiramo događaj
            ga.DižiAlarm("zahod", 0, "propuh");


            Console.WriteLine("Slušatelj će se prijaviti nakon što stisnemo tipku");
            Console.ReadKey(true);


            // kreiramo objekt koji će se pretplatiti na događaje
            SlušateljAlarma sa = new SlušateljAlarma();
            // dodajemo ga kao slusštelja
            ga.Alarm += sa.AlarmNotifikacija;


            Console.WriteLine("Ništa se ne događa dok ne stisnemo tipku");
            Console.ReadKey(true);
            
            
            // test: generiramo događaj
            ga.DižiAlarm("učiona", 3, "počinitelj krade žarulje");

            
            Console.WriteLine("Slušatelj će se odjaviti nakon što stisnemo tipku");
            Console.ReadKey(true);

            // odjavimo se od primanja događaja
            ga.Alarm -= sa.AlarmNotifikacija;
            ga.DižiAlarm("hodnik", 1, "mačka");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
