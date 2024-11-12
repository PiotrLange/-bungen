using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ubung_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            string pangram = "The quick brown fox jumps over the lazy dog";

            
            char[] charArray = pangram.ToCharArray();                  // Converting String to Char (zeichen) Array
            Array.Reverse(charArray);                               // Reversing char Array
            string reversedPangram = new string(charArray);     //new string(charArray) macht ein Array aus 
                                                                //reverste zeichen 

            Console.WriteLine("Oryginalny tekst: " + pangram);
            Console.WriteLine("Odwrócony tekst: " + charArray);

            Console.ReadLine();

            */

            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.ReadLine();


        }

    }




}
