using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ubung12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine(daysUntilExpiration);
            
            if (daysUntilExpiration >= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now! ");
            }
            if (daysUntilExpiration < 10 || daysUntilExpiration >= 5 )
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. ");
                discountPercentage = 10;
            }
            if (daysUntilExpiration <= 4)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. ");
                discountPercentage = 20;
            }
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine($"Your subscription has expired");
            }
            if (daysUntilExpiration < 10)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
            Console.ReadLine();

               






        }

    }
    
}
