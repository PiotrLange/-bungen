using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubung11_Schulaufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             
           //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
           
             Schreibe ein Computerprogramm, das eine dezimal Eingabe in hexadezimal, oktal, binär konvertiert und ausgibt.

           //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
           */



            char auswahl;
            // Loop für den Neustart. char liest ein Zeichen ein, das wir als "auswahl" genannt haben.

            do
            {

                Console.Clear();         
                Console.WriteLine("Gib eine beliebige ganze Zahl ein, die nicht größer als int. ist  (max int. = 2 147 483 647)");
                

                if (int.TryParse(Console.ReadLine(), out int meinZahl))
                // Wenn die korrekte Zahl eingegeben wird, dann:

                {

                    string BinarZahl = Convert.ToString(meinZahl, 2);
                    //Der Wert 2 als zweites Argument bedeutet das binäre (zweier) System,
                    //Beispiel für "15"   
                    //15÷2 = 7(14) und rest 1
                    //7÷2 = 3 und rest 1
                    //3÷2 = 1 und rest 1
                    //1÷2 = 0 und rest 1
                    // Also das ergebnis ist = 1111
           

                    string OktanZahl = Convert.ToString(meinZahl, 8);


                    string HexadecimalZahl = Convert.ToString(meinZahl, 16).ToUpper();


                    Console.WriteLine($"Zahl im Binärsystem: {BinarZahl}");
                    Console.WriteLine($"Zahl im Oktalsystem: {OktanZahl}");
                    Console.WriteLine($"Zahl im Hexadecimalsystem: {HexadecimalZahl}");

                }
                else
                {
                    Console.WriteLine("Ungültiger Wert. Bitte geben Sie eine gültige ganze Zahl im Bereich des int.-Werts ein.");
                }


                
                Console.WriteLine("Drücken Sie 's', um das Programm erneut zu starten, oder eine beliebige andere Taste, um zu beenden..");
                auswahl = Console.ReadKey().KeyChar;
                // Erstellt einfach eine Schleife/Loop, um das Programm mit 's' neu zu starten.

            }
            while (auswahl == 's');
        }

    }

}
    

