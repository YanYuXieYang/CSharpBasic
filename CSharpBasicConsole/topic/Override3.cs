using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    internal class Override3
    {
        public Override3()
        {
            Class2 c2 = new Class2();
            c2.MethodA();// BaseClass.MethodA
            c2.MethodB();// Class2.MethodB
            Class1 class1 = new Class1();
            class1.MethodA();// BaseClass.MethodA
            class1.MethodB();// Class1.MethodB
            BaseClass b1 = new Class1();
            b1.MethodA();// BaseClass.MethodA
            b1.MethodB();// Class1.MethodB
            BaseClass b2 = new Class2();
            b2.MethodA();// BaseClass.MethodA
            b2.MethodB();// Class1.MethodB
        }

        abstract class BaseClass
        {
            public virtual void MethodA() { Console.WriteLine("BaseClass.MethodA"); }
            public virtual void MethodB() { Console.WriteLine("BaseClass.MethodB"); }
        }
        class Class1 : BaseClass
        {
            public void MethodA(string arg) // 注意，是有参的
            { Console.WriteLine("Class1.MethodA"); }
            public override void MethodB() {
                Console.WriteLine("Class1.MethodB");
            }
        }
        class Class2 : Class1
        {
            new public void MethodB() {
                Console.WriteLine("Class2.MethodB");
            }
        }
    }
}
