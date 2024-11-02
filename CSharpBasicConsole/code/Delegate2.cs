using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    public delegate void MessageHanlder(string message);
    class Delegate2
    {
        public Delegate2()
        {
            var hanlder = new MessageHanlder(AMethod);
            hanlder += BMethod;
            hanlder += AMethod;
            hanlder("test");
            DelegateFunc(hanlder);
        }
        static void AMethod(string message)
        {
            Console.WriteLine($"AMethod：{message}");
        }
        static void BMethod(string message)
        {
            Console.WriteLine($"BMethod：{message}");
        }
        static void DelegateFunc(MessageHanlder handler)
        {
            handler("DelegateFunc call");
        }
    }
}
