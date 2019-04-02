using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Twitter : SocialNetwork
    {
        public Twitter(string login)
        {
            Console.WriteLine("Sign in to: " + login);
        }

        public override void Send(string messange)
        {
            Console.WriteLine("Нажать кнопку 'New'");
            Post(messange);
        }
    }
}
