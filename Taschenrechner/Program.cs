using System;


namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe der zwei Zahlen wo addiert werden soll
            Console.Write("Bitte gib die erste Zahl ein: ");
            string ersteZahl = Console.ReadLine();
            Console.Write("Bitte gib die zweite Zahl ein: ");
            string zweiteZahl = Console.ReadLine();

            // Wandelt Text in Ganzzahlen
            int ersteZahlAlsZahl = Convert.ToInt32(ersteZahl);
            int zweiteZahlAlsZahl = Convert.ToInt32(zweiteZahl);

            // Berechnung
            int summe = ersteZahlAlsZahl + zweiteZahlAlsZahl;

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();
        }
    }
}
