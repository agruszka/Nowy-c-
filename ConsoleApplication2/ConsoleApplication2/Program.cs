using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimum = 0;
            int maximum = 0;
            Input("First number: ", ref minimum);
            Input("Second number: ", ref maximum);
            addNumbers(minimum, maximum);

            Console.ReadLine();
        }

        static void addNumbers(int min, int max)
        {
            Random rnd = new Random();
            int numero1 = rnd.Next(min, max);
            int numero2 = rnd.Next(min, max);
            Console.WriteLine($"Type first number: {numero1}. Type second random number: {numero2}");
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
        }

        static void Input(string description, ref int inputVariable)
        {
            Console.Write(description);
            inputVariable = Convert.ToInt32(Console.ReadLine());
          
   

        }
    }
}