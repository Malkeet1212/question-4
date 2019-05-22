using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string operation;
            Console.Write("Enter your First Number");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter operation");
            operation = Console.ReadLine();

            Console.Write("Enter your second Number");
            b = int.Parse(Console.ReadLine());
            switch(operation)
            {
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "%":
                    Console.WriteLine(a % b);
                    break;
                default:
                    Console.WriteLine("wrong Character");
                    break;

            }

           

        }
    }
}
