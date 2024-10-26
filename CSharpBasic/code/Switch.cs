using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    class Switch
    {
        public Switch()
        {
            byte b = 1;
            string s = "s1";
            long l = 100;
            switch (b)
            {
                default:
                    Console.WriteLine("byte default");
                    break;
                case 1:
                    Console.WriteLine("byte 1");
                    break;
            }
            switch (s)
            {
                case "s1":
                    Console.WriteLine("string 100");
                    break;
                default:
                    Console.WriteLine("string default");
                    break;
            }
            switch (l)
            {
                case 100:
                    Console.WriteLine("long 1");
                    break;
                default:
                    Console.WriteLine("long default");
                    break;
            }
        }
    }
}
