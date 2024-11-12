using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubung_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);                   // Array.Reverse - sortiert pallets ruckwerts 
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Array.Clear(pallets, 0, 2);              // Array.Clear - löscht im ergebnis die erste zwei elemente aus dem Array pallets
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("");
            Array.Resize(ref pallets, 6);           // Array.Resize - stellt die grose von Arry auf von 4 auf 6 elemnte
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";                    // das die die zusetzliche 2 Elemnte 
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.ReadLine();

            /*

            1. Beispiel für Array.Reverse

            string value = "abc123";
            char[] valueArray = value.ToCharArray();    
            Array.Reverse(valueArray);
            string result = new string(valueArray);
            Console.WriteLine(result);


            2. Beispiel für auseinander zu stellen

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
                // string result = new string(valueArray);
            string result = String.Join(",", valueArray);      Beispiel für auseinander zu stellen
            Console.WriteLine(result);


            3.



            */

        }

    }
}
