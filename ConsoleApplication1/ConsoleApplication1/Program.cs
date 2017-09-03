using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć, jak masz na imię?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Powiedz mi jeszcze ile masz lat?");
            string wiek;
            wiek = Console.ReadLine();

            Console.WriteLine("Cześć " + name + ", fajnie, że masz " + wiek + " lat");
            Console.ReadLine();
        }
    }
}
