using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class ArgNullException:Exception
    {
        public ArgNullException(string message):base(message)
        {

        }
    }
}
