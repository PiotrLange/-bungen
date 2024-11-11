using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ubung2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine(daysUntilExpiration);

            if (daysUntilExpiration < 1)
            {
                Console.WriteLine("Your subscription has expired.");
                Console.ReadLine();
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                Console.WriteLine("Renew now and save 20%!");
                Console.ReadLine();
            }
            else if (daysUntilExpiration > 1 && daysUntilExpiration <= 6)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                Console.WriteLine("Renew now and save 10%!");
                Console.ReadLine();
            }
            else if (daysUntilExpiration > 6)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
                Console.ReadLine();
            }
        }
//                   Unten das Ergebnis mit %%
//
//    }//Random random = new Random();
//    int daysUntilExpiration = random.Next(12);
//    int discountPercentage = 0;

//if (daysUntilExpiration == 0)
//{
//    Console.WriteLine("Your subscription has expired.");
//}
//else if (daysUntilExpiration == 1)
//{
//    Console.WriteLine("Your subscription expires within a day!");
//    discountPercentage = 20;
//}
//else if (daysUntilExpiration <= 5)
//{
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//    discountPercentage = 10;
//}
//else if (daysUntilExpiration <= 10)
//{
//    Console.WriteLine("Your subscription will expire soon. Renew now!");
//}

//if (discountPercentage > 0)
//{
//    Console.WriteLine($"Renew now and save {discountPercentage}%.");
//}

}
