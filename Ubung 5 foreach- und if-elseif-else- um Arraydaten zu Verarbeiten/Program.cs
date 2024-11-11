using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Ubung_5_foreach__und_if_elseif_else__um_Arraydaten_zu_Verarbeiten
{
    internal class Program
    {
        static void Main(string[] args)


        {

            // Ein Programm, in dem wir den Namen des Studenten eingeben und dann
            // die Punktzahl angeben, die er erhalten hat. Das Programm vergibt automatisch eine Note basierend auf der Punktzahl



            string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };


            foreach (string name in studentNames)
            {
                Console.WriteLine("Write a student Name:");
                string studentName = Console.ReadLine();


                if (Array.Exists(studentNames, element => element == studentName))
                // Array.Exists - wird nur fortgesetzt, wenn der eingegebene Name in unserem studentNames-Array vorhanden ist.

                {
                    Console.WriteLine($"How many points has {studentName} the recived ?");
                    int punkte;


                    if (int.TryParse(Console.ReadLine(), out punkte) && punkte >= 0 && punkte <= 60)
                    //int.TryParse ist eine Methode, die überprüft, ob eine gegebene Zeichenkette in eine ganze Zahl umgewandelt werden kann.

                    {
                        Console.WriteLine($"{studentName} has resived a F");
                    }
                    else if (punkte >= 61 && punkte <= 70)
                    {
                        Console.WriteLine($"{studentName} has resived a E");
                    }
                    else if (punkte >= 71 && punkte <= 80)
                    {
                        Console.WriteLine($"{studentName} has resived a D");
                    }
                    else if (punkte >= 81 && punkte <= 100)
                    {
                        Console.WriteLine($"{studentName} has resived a A");
                    }
                }
                Console.ReadLine();




            }

        }









    }
}
