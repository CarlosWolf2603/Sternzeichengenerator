using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace HalloWelt_CarlosWolf
{
    internal class Program
    {
        public static string ConvertToDateTim { get; private set; }


        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////// Beginn Aufgabe 2 /////////////////////////////////////////////////////////// 


            int day, month; // Deklaration für Tag und Monat der Variablen

        Label:

            Console.Write("Gib den Tag des Monats ein an dem du Geburtstag hast: ");

            // Benutzer wird aufgefordert den Tag einzugeben

            day = int.Parse(Console.ReadLine());

            // Benutzereingabe für den Tag wird gespeichert

            Console.Write("Gib den Monat ein an dem du geboren wurdest: ");

            // Benutzer wird aufgefordert den Monat einzugeben

            month = int.Parse(Console.ReadLine());

            // Benutzereingabe Monat wird gespeichert

            Console.Write("Gib das Jahr aus in dem du geboren wurdest: ");
            Console.ReadLine();

            // Bedingte Anweisungen werden festgelegt

            if ((day >= 21 & month == 4) || (day <= 21 & month == 5))
                Console.WriteLine("Dein Sternzeichen ist: Stier");

            if ((day >= 24 & month == 10) || (day <= 22 & month == 11))
                Console.WriteLine("Dein Sternzeichen ist: Skorpion");

            if ((day >= 22 & month == 5) || (day <= 21 & month == 6))
                Console.WriteLine("Dein Sternzeichen ist: Zwilling");

            if ((day >= 23 & month == 11) || (day <= 21 & month == 12))
                Console.WriteLine("Dein Sternzeichen ist: Schütze");

            if ((day >= 21 & month == 6) || (day <= 23 & month == 7))
                Console.WriteLine("Dein Sternzeichen ist: Krebs");

            if ((day >= 24 & month == 7) || (day <= 23 & month == 8))
                Console.WriteLine("Dein Sternzeichen ist: Löwe");

            if ((day >= 21 & month == 1) || (day <= 19 & month == 2))
                Console.WriteLine("Dein Sternzeichen ist: Wassermann");

            if ((day >= 24 & month == 8) || (day <= 23 & month == 9))
                Console.WriteLine("Dein Sternzeichen ist: Jungfrau");

            if ((day >= 21 & month == 3) || (day <= 20 & month == 4))
                Console.WriteLine("Dein Sternzeichen ist: Widder");

            if ((day >= 24 & month == 9) || (day <= 23 & month == 10))
                Console.WriteLine("Dein Sternzeichen ist: Waage");

            if ((day >= 22 & month == 12) || (day <= 20 & month == 1))

                // Ausgabe des jweiligen Sternzeichens welches für die Benutzereingabe festgelegt ist

                Console.WriteLine("Dein Sternzeichen ist: Steinbock");

            Console.ReadKey();
        }
    }
}