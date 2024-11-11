using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ubung9_Konvertieren_von_Datentypen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //     Konvertierung von __int__ in __string__ Beispiel    

            //int first = 5;
            //int second = 7;
            //string message = first.ToString() + second.ToString();                    // ToString - conwerts int to string
            //Console.WriteLine(message);

            //Console.ReadLine();






            //     Konvertierung von __string__ in __int___  Beispiel  nr. 1  

            //string first = "5";
            //string second = "7";
            //int sum = int.Parse(first) + int.Parse(second);                          // int.Parse - conwerts string to int
            //Console.WriteLine(sum);

            //Console.ReadLine(); 







            //     Konvertierung von __string__ in __int__ Möglichkeit   Beispiel nr.2     

            //string value1 = "5";
            //string value2 = "7";
            //int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);           // Convert.ToInt32 conwerts string to int
            //Console.WriteLine(result);

            //Console.ReadLine();




            //            Verwende ___int.Parse()___, wenn du sicher bist, dass du einen String hast und nur gültige Zahlen konvertieren möchtest,
            //            und du weißt, dass der String nicht null sein wird.
            //            Verwende ___Convert.ToInt32()___, wenn du verschiedene Datentypen(z.B. null, Gleitkommazahlen, boolesche Werte)
            //            verarbeiten möchtest und wenn du Zeichenfolgen sicherer in Zahlen umwandeln möchtest, einschließlich der
            //            Verarbeitung von null - Werten.
            // 






            //     Konvertierung von __string__ in __int__ Möglichkeit   Beispiel  nr.3   

            //string value = "102";
            //int result = 0;
            //if (int.TryParse(value, out result))  //
            //{
            //    Console.WriteLine($"Measurement: {result}");          // Die Variable result wird durch die Methode TryParse() aktualisiert,
            //                                                          // und da "102" eine gültige Zahl ist, ändert sich der Wert von result von 0 auf 102.
            //}
            //else
            //{
            //    Console.WriteLine("Unable to report the measurement.");
            //}
            //Console.WriteLine($"Measurement (w/ offset): {50 + result}");

            //Console.ReadLine();





            //                            __________________________Ubung   1

            //    Aus Array[values] - soll dein code 
            //    unter "total"alle zahlen in summieren und 
            //    unter "Message" alle Buchstabe summieren




            //string[] values = { "12.3", "45", "ABC", "y", "DEF" };

            //decimal total = 0m;
            //string Message = "";


            //foreach (var value in values)   //    für jede werte aus Arry [values]
            //{
            //    decimal number;            //    Speichert den "out"-Wert von TryParse.
            //    if (decimal.TryParse(value, out number))
            //    {
            //        total += number;
            //    }
            //    else
            //    {
            //        Message += value;
            //    }
            //}

            //Console.WriteLine($"Message: {Message}");
            //Console.WriteLine($"Total: {total}");

            //Console.ReadLine();





            //                     __________________________Ubung   2





            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;


            {
                int result1 = value1 / Convert.ToInt32(value2);



                // Your code here to set result1
                // Hint: You need to round the result to nearest integer (don't just truncate)
                Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            }


            // Your code here to set result2
            
            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
            {

                // Your code here to set result3
                float result3 = value3 / value1;
                Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


                Console.ReadLine();
            }




            /*
            1. Konwersja liczbowych typów danych:
a) float -> decimal:

  
float f = 1.23f;
decimal d = (decimal)f;

Metoda Convert:

    decimal d = Convert.ToDecimal(f);


b) decimal -> int:

decimal d = 12.34m;
int i = (int)d; // Utrata części ułamkowej

Metoda Convert:


    int i = Convert.ToInt32(d); // Zaokrąglanie do najbliższej liczby całkowitej


c) double -> float:

    double d = 1.234;
    float f = (float)d;


d) long -> int:

long l = 12345L;
int i = (int)l;

Metoda Convert:

    int i = Convert.ToInt32(l);


2. Konwersja tekstowa (string) na liczby:
a) string -> int:

    Metoda int.Parse:

string str = "123";
int i = int.Parse(str);


Metoda Convert:

int i = Convert.ToInt32(str);

Metoda TryParse (bezpieczna konwersja):


    int i;
    bool success = int.TryParse(str, out i);

b) string -> float:

    Metoda float.Parse:


    string str = "1.23";
    float f = float.Parse(str);

c) string -> decimal:

    Metoda decimal.Parse:


    string str = "12.34";
    decimal d = decimal.Parse(str);

3. Konwersja liczb na string:

    Metoda ToString (dla wszystkich typów liczbowych):


    int i = 123;
    string str = i.ToString();

4. Konwersja boolean:
a) bool -> int:

    Rzutowanie nie działa, ale można użyć metody konwersji:


    bool b = true;
    int i = b ? 1 : 0; // True jako 1, False jako 0

b) int -> bool:

    Rzutowanie nie działa, ale można użyć warunku:


    int i = 1;
    bool b = i != 0; // Jeśli i równe 0, to False; w przeciwnym razie True

5. Konwersja obiektów na typy wartościowe:
a) object -> int:

    Rzutowanie:


object obj = 123;
int i = (int)obj;

Metoda Convert:


    int i = Convert.ToInt32(obj);

b) object -> string:


    object obj = "Hello";
    string str = obj.ToString();

6. Implicit (niejawna) i explicit (jawna) konwersja:
a) Niejawna konwersja (bez rzutowania):

Niejawna konwersja działa, gdy mniejszy typ danych jest automatycznie konwertowany na większy.


int i = 123;
long l = i; // Niejawna konwersja int na long

b) Jawna konwersja (wymaga rzutowania):

Gdy większy typ danych musi zostać skonwertowany na mniejszy, musisz użyć jawnego rzutowania.


long l = 123456789;
int i = (int)l; // Jawna konwersja long na int


            */

        }
    }
}
