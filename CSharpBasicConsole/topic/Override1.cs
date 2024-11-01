using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpBasic.code.Static;

namespace CSharpBasicConsole.topic
{
    internal class Override1
    {
        public Override1()
        {

            Son b = new Son();
            Father a = b;
            a.F();
            b.F();
            a.G();
            b.G();
            Console.WriteLine();
        }

        class Father
        {
            public void F()
            {
                Console.Write("A.F ");
            }
            public virtual void G()
            {
                Console.Write("A.G ");
            }
        }
        class Son : Father
        {
            new public void F()
            {
                Console.Write("B.F ");
            }

            public override void G()
            {
                Console.Write("B.G ");
            }
        }
    }
}
