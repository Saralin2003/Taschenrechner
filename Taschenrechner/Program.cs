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
            float ersteZahlAlsZahl = Convert.ToSingle(ersteZahl);
            float zweiteZahlAlsZahl = Convert.ToSingle(zweiteZahl);

            // Berechnung
            float summe = ersteZahlAlsZahl + zweiteZahlAlsZahl;

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();
        }
    }
}
