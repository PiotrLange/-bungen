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
          void SayHello(string name) 
            {
            Console.WriteLine("Hallo " + name);
                Console.WriteLine("Wie gehts");
                Console.WriteLine("----");
            }
            SayHello("Alina");
            SayHello("Darek");

            Console.ReadLine();
        }

    }

    }

