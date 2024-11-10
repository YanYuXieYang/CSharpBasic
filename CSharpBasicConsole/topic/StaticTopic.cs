using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    internal class StaticTopic
    {
        public StaticTopic()
        {
            Console.WriteLine("X={0},Y={1}", A.X, B.Y);
        }
        class A
        {
            public static int X;
            static A()
            {
                Console.WriteLine("A(),X={0}, Y={1}", X, B.Y);
                X = B.Y + 1;
            }
        }
        class B
        {
            public static int Y = A.X + 1;
            static B()
            {
                Console.WriteLine("B(),X={0}, Y={1}", A.X, Y);
            }
        }
    }
}
