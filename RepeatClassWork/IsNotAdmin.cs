using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class IsNotAdmin:Exception
    {
        public IsNotAdmin(string message):base(message)
        {
           

        }
    }
}
