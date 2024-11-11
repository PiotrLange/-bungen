using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubung3_Array
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ///////////////////////////////////////       Beispiel 1      /////////////////////////////////////////////////////////////////

            //int[] inventory = { 200, 450, 700, 175, 250 };        //  []to jest nasza tabela z danymi "inventory"
            //int sum = 0;                                          //to bedzie nasz suma dodawanych ze soba inventory
            //int bin = 0;
            //foreach (int items in inventory)
            //{
            //    sum += items;                                      //dodajac znak po sum - kazesz wykonac dzislanie - moze byc +, -, *
            //    bin++;                                             // bi = bin++ to skrut na bin ="bin + 1"
            //    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            //}
            //Console.WriteLine($"We have {sum} items in inventory.");
            //{
            //    Console.ReadLine();
            //}




            /////////////////////////////////////////////////      Beispiel 2      //////////////////////////////////////////////////////     
            ////Es wird kein Menü gezeigt -  es zeigt einfach nach Drücken von A, B oder C die ID an.


            //string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            //foreach (string orderID in orderIDs)
            //{
            //    Console.ReadLine();
            //    if (orderID.StartsWith("B"))
            //    {
            //        Console.WriteLine("The name starts with 'B'!");
            //        Console.WriteLine(orderID);
            //    }
            //    if (orderID.StartsWith("A"))
            //    {
            //        Console.WriteLine("The name starts with 'A'!");
            //        Console.WriteLine(orderID);
            //    }
            //    if (orderID.StartsWith("C"))
            //    {
            //        Console.WriteLine("The name starts with 'C'!");
            //        Console.WriteLine(orderID);

            //    }

            //    Console.ReadLine();


            ///////////////////////////////////////////////////      Beispiel 3      ///////////////////////////////////////////////
            ////




            {
                
                string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

                Console.WriteLine("Wählen Sie eine Buchstaben (A, B,C) um die IDs zu erwählen");
                string choice = Console.ReadLine();
                
                foreach (string orderID in orderIDs)
                
                {
                    if (orderID.StartsWith(choice))

                    //derID.StartsWith(choice) - StartsWith - Zeig alle, die mit dem Buchstaben beginnen, den du eingibst

                    {
                        Console.WriteLine($"Ihre ausgewählte IDs sind {orderID}");
                    }
                }

                Console.ReadLine();

                

            }

        }




    }
}
