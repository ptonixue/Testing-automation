using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am first calc by Kate. You can add(+), subtraction(-), multiply(*) and divide(/) a numbers. Press \"Ctrl+C\" for exit.");

            while (true)
            {

                Console.Write("What kind of operation do you want? Write operator: ");
                string op = Console.ReadLine();

                Console.Write("Write first arg: ");
                string line = Console.ReadLine();
                int arg1 = 0;

                bool ok = int.TryParse(line, out arg1);
                if (!ok) {
                    Console.WriteLine("Error! Write number!");
                    continue;
                }              

                Console.Write("Write second arg: ");
                line = Console.ReadLine();
                int arg2 = int.Parse(line);

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = add(arg1, arg2);
                        break;
                    case "-":
                        result = sub(arg1, arg2);
                        break;
                    case "*":
                        result = mult(arg1, arg2);
                        break;
                    case "/":
                        result = div(arg1, arg2);
                        break;
                    default:
                        Console.WriteLine("Error! Write correct operation!");
                        break;
                }

                Console.WriteLine("Result: {0}", result);

                Console.Write("Do you want to continue? Press any key to continue or 'N' to exit: ");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.N:
                    case ConsoleKey.Escape:
                        return;
                }

                Console.WriteLine();

            }
        }

        static double add(double a, double b)
        {
            return a + b;
        }

        static double sub(double a, double b)
        {
            return a - b;
        }

        static double mult(double a, double b)
        {
            return a * b;
        }

        static double div(double a, double b)
        {
            return a / b;
        }
    }

}
