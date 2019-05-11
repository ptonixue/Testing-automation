using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.BO
{
    class TestPostGenerator
    {
        public static Post GeneratePost()
        {
            return new Post("New Head", "Link", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Assumenda, cum.");
        }

        public static Post GeneratePostNum2()
        {
            return new Post("New Head 2", "Link 2", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Assumenda, cum.");
        }
    }
}
