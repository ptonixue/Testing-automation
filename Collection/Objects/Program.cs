using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICommunicator> packege = new List<ICommunicator>();
            packege.Add(new Instagram("red_line"));
            packege.Add(new Instagram("green_line"));
            packege.Add(new Twitter("blue_line"));
            packege.Add(new Messenger());

            Console.WriteLine("packege: ");
            printLogins(packege);

            // Sort
            packege.Sort(delegate (ICommunicator x, ICommunicator y)
            {
                if (x.Login == null && y.Login == null) return 0;
                else if (x.Login == null) return -1;
                else if (y.Login == null) return 1;
                else return x.Login.CompareTo(y.Login);
            });

            Console.WriteLine("\nSorted packege: ");
            printLogins(packege);

            // filter by Lambda
            var linesLambda = packege.Where(p => p.Login != null && p.Login.StartsWith("green"));
            Console.WriteLine("\nFiltered by Lambda packege: ");
            printLogins(linesLambda);

            // filter by LINQ
            IEnumerable<ICommunicator> lines = from p in packege
                                               where p.Login != null && p.Login.StartsWith("blue")
                                               select p;
            Console.WriteLine("\nFiltered by LINQ packege: ");
            printLogins(lines);

            Console.ReadKey();
        }

        static void printLogins(IEnumerable<ICommunicator> packege)
        {
            foreach (ICommunicator p in packege)
            {
                Console.WriteLine("Login: " + p.Login);
            }
        }
    }
}
