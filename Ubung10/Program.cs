using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Ubung10
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //__________________________________________________________Ubung 1     Sorted und Reverse

            /*
             

            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);                   // Die Methode Array.Sort(pallets) sortiert die Elemente
                                                    // im Array pallets alphabetisch      
            
            
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");  //Die foreach-Schleife durchläuft jedes Element des sortierten
                                                    //Arrays pallets und gibt es in der Konsole aus,
                                                    //mit einem Präfix "-- " vor jeder Palettenbezeichnung. Dies zeigt
                                                    //dem Benutzer, wie das sortierte Array aussieht.
            }
            Console.WriteLine("");                  //Eine leere Zeile (Console.WriteLine("");) fügt einen Abstand
                                                    //zwischen der Ausgabe des sortierten und des umgekehrten Arrays ein.
            
            Console.WriteLine("Reversed...");      
            Array.Reverse(pallets);                  //Die Methode Array.Reverse(pallets) kehrt die Reihenfolge der Elemente
                                                     //im Array pallets um. Das bedeutet, dass das erste Element das letzte
                                                     //wird und das letzte Element das erste.
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.ReadLine();



            */



            //____________________________________________________________Ubung 2     Clear und Resize


            /*

            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);                                     //Array.Clear(pallets, 0, 2);: Diese Methode löscht
                                                                            //die ersten zwei Elemente des Arrays pallets,
                                                                            //beginnend bei Index 0. Diese beiden Positionen
                                                                            //werden auf null gesetzt (da es sich um ein
                                                                            //String-Array handelt).
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 6);                                      //Array.Resize(ref pallets, 6);: Diese Methode ändert
                                                                               //die Größe des Arrays pallets auf 6 Elemente. Es werden
                                                                               //also zwei neue Elemente hinzugefügt, die den Wert null haben.
            Console.WriteLine($"Resizing 6 ... co
            nt: {pallets.Length}");

            pallets[4] = "C01";                                             //Diese Anweisungen weisen den letzten beiden neuen Elementen,
            pallets[5] = "C02";                                             //die durch das Vergrößern des Arrays hinzugefügt wurden, neue
                                                                            //Werte zu. Index 4 erhält "C01" und Index 5 erhält "C02".


            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 3);                                   //Array.Resize(ref pallets, 3);: Diese Methode ändert die Größe des
                                                                            //Arrays auf 3 Elemente. Das bedeutet, dass alle Elemente nach
                                                                            //Index 2 (also "B12" und folgende) entfernt werden.
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.ReadLine();

            //////////////               Zusammenfassung        //////
            //Array.Clear hat die ersten zwei Elemente des Arrays gelöscht und auf null gesetzt.
            //Array.Resize(6) hat die Größe des Arrays auf 6 vergrößert, wobei zwei neue Elemente(null)
            //hinzugefügt wurden, die später mit "C01" und "C02" belegt wurden.
            //Array.Resize(3) hat das Array auf 3 Elemente verkleinert und alle Elemente nach dem dritten entfernt.


            */





            //__________________________________________Ubung 3    Split and Join


            /*
             

            string value = "abc123";
            char[] valueArray = value.ToCharArray();            // char speichert ein einzelnes Zeichen in einfachen Anführungszeichen ('), z. B. 'A', '1', '#'.
                                                                // Hingegen ist string ein Datentyp, der eine Zeichenkette(Text) speichert.
                                                                // char[] valueArray = value.ToCharArray(); konvertiert den String value in ein
                                                                // Zeichen-Array (char[]), wobei jedes Zeichen des Strings zu einem Element des Arrays wird.

            Array.Reverse(valueArray);

            
            string result = String.Join(",", valueArray);       //Die Methode verbindet alle Elemente des Arrays valueArray zu einem String, wobei die
                                                                //Elemente durch das angegebene Trennzeichen (Komma) getrennt werden.


            Console.WriteLine(result);

            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();




            */


            //__________________________________________Ubung 4   reverse the words


            string pangram = "The quick brown fox jumps over the lazy dog";
            char[] charArray = pangram.ToCharArray();                           // macht Array aus pangram 

            Array.Reverse(charArray);                                           //mit reverse dreht pangramArray um

            string reversedpangram = new string(charArray);                     //macht neuen string pangram aus dem umgekehrten pangramArray

            Console.WriteLine(reversedpangram);
            Console.ReadLine();

        }
            

        
    }
}
