using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class SocialNetwork : ICommunicator
    {
        public virtual void Send(string messange)
        {
            Console.WriteLine("Нажать кнопку 'New'");
            Post(messange);
        }

        public void Post(string messange)
        {
            Console.WriteLine("Публикация поста: " + messange);
        }
    }
}
