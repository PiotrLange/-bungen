using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Ubung12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int heroLive = 20;
            int monsterLive = 20;

            Random randomFight = new Random();

            Console.WriteLine($"Hero Live is {heroLive} and Monster Live is {monsterLive}");

            do
            {
                int heroAtak = randomFight.Next(1, 4);
                monsterLive -= heroAtak;
                Console.WriteLine($"Monster was demaged and lost {heroAtak} from his Live");

                if (monsterLive <= 0)
                {
                    Console.WriteLine("Hero Wins !!");
                    break;
                }

                int monsteAtak = randomFight.Next(1, 4);
                monsterLive -= monsteAtak;
                Console.WriteLine($"Hero was demaged and lost {monsteAtak} from his Live");

                if (heroLive <= 0)
                {
                    Console.WriteLine("Monster Wins !!");
                    break;
                }



            }
            while (heroLive > 0 && monsterLive > 0);

            Console.ReadLine();
        }
    }

}

