using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Instagram : SocialNetwork
    {
        public Instagram(string login)
        {
            Login = login;
            Console.WriteLine("Sign in to: " + login);
        }

        public override void Send(string messange)
        {
            Console.WriteLine("Выбрать изображение");
            Post(messange);
        }
    }
}
