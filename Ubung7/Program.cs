using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ubung7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Branch the flow of code using the switch-case construct in C#         //
            // Das Programm sucht die Position des Mitarbeiters basierend auf seinem Level unter Verwendung der Switch/Case-Methode.





            //int employeeLevel = 201;
            //string employeeName = "John Smith";

            //string title = "";

            //switch (employeeLevel)

            //{

            //    case level when(0 >= 100):
            //        title = "Junior Associate";
            //        break;
            //    case 200:
            //        title = "Senior Associate";
            //        break;
            //    case 300:
            //        title = "Manager";
            //        break;
            //    case 400:
            //        title = "Senior Manager";
            //        break;
            //    default:
            //        title = "Associate";
            //        break;
            //}

            //Console.WriteLine($"{employeeName}, {title}");

            //Console.ReadLine();






            /////////////////////////////////                   Beispiel 2                          ////////////////////////
            // Ein Programm sucht basierend auf den "SKU"-Daten die Größe, Art und Farbe des T-Shirts
            // unter Verwendung der Switch/Case-Methode.




            string sku = "01-MN-L"; //Produkt Data

            string[] product = sku.Split('-');  //Split('-') - Die Methode Split() teilt eine Zeichenkette in Teile,
                                                //indem sie einen bestimmten Trennzeichen verwendet, in diesem Fall das Minuszeichen ('-').
                                                //Das bedeutet, dass die Methode Split() die Zeichenkette in ein Array umwandelt,
                                                //indem sie die Zeichenkette dort trennt, wo das Minuszeichen auftritt.

            string type = "";
            string color = "";
            string size = "";        //Die Zeichen "" sind eine leere Zeichenkette(engl.empty string). Sie bedeuten, dass die
                                     //Variablen type, color und size als leere Zeichenketten initialisiert wurden, also keine
                                     //Daten enthalten.
            

            switch (product[0])
            { 
            case "01": 
                type = "Sweat shirt";
                break;

            case "02":
                type = "T-Shirt";
                break;
           
            case "03": 
                type = "Sweat pants";
                break;
               
            default:
                type = "Other";
                break;
            }

            switch (product[1])
            {
                case "BL":
                color = "Black";
                break;


                case "MN":
                color = "Maroon";
                break;

                default:
                color = "White";
                break;
            }

            switch (product[2])            
            {
                case "S": 
                size = "Small";
                break;

                case "M":
                size = "Medium";
                break;
            
                case "L":
                size = "Large";
                break;

                default:
                size = "One Size Fits All";
                break;
                }

            Console.WriteLine($"Product: {size} {color} {type}");

            Console.ReadLine();

            
        }

    }

}
