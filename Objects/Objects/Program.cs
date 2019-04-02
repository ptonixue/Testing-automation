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
            var packege = new List<ICommunicator>();
            packege.Add(new Instagram("red_line"));
            packege.Add(new Instagram("green_line"));

            packege.Add(new Twitter("blue_line"));

            packege.Add(new Messenger());

            foreach (var p in packege)
            {
                p.Send("hello");
            }

            Console.ReadKey();
        }
    }
}
