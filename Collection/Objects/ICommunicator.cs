using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    //Send a messange
    abstract class ICommunicator
    {
        public string Login;
        
        public abstract void Send(string messange);
    }
}
