using System;

namespace Modifier
{
    /// <summary>
    /// C#访问修饰符
    /// 官方：https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers?redirectedfrom=MSDN
    /// https://blog.csdn.net/m0_37816922/article/details/129086538
    /// </summary>
    public class Class1
    {
        //void test()
        //{
        //    var test = new TestClass();
        //    test.pubPrint();
        //    test.priPrint();
        //    test.proPrint();
        //    test.IntPrint();
        //    test.priProPrint();
        //    test.proIntPrint();
        //}
    }
    public class Class2:TestClass
    {
        //void test2()
        //{
        //    pubPrint();
        //    priPrint();
        //    proPrint();
        //    IntPrint();
        //    priProPrint();
        //    proIntPrint();
        //}
    }
    public class TestClass
    {
        public void pubPrint()
        {
            Console.WriteLine("public");
        }
        private void priPrint()
        {
            Console.WriteLine("private");
        }
        protected void proPrint()
        {
            Console.WriteLine("protected");
        }
        internal void IntPrint()
        {
            Console.WriteLine("internal");
        }
        private protected void priProPrint()
        {
            Console.WriteLine("private protected");
        }
        protected internal void proIntPrint()
        {
            Console.WriteLine("protected internal");
        }
    }

}
