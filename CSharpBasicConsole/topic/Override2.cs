using CSharpBasicConsole.topic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    internal class Override2
    {
        public Override2()
        {
            Base obj = new Sub();
            obj.Func();
            Console.WriteLine();
        }
        class Base
        {
            public Base() { Func(); }
            public virtual void Func()
            {
                Console.Write("Base.Func ");
            }
        }
        class Sub : Base
        {
            public Sub() { Func(); }
            public override void Func()
            {
                Console.Write("Sub.Func ");
            }
        }
    }
}
