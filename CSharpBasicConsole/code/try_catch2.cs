using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    /// <summary>
    /// return语句会先压入栈里面，最后执行finally语句（有return语句，值压入栈中），最后弹出栈顶元素。
    /// finally会执行，在方法返回调用前执行。准确的说是在return中间执行。
    /// </summary>
    public class Try_catch2
    {
        public Try_catch2()
        {
            //Console.WriteLine("结果： {0}" , new Test().test());
            //Console.WriteLine("结果： " + new Test().test2());
            //Console.WriteLine("结果： " + new Test().test3());
            string s = "abc";
            Console.WriteLine("结果： " + new Test().test4(ref s) + ", s: " + s);
            A a = new A();
            A b = new Test().test5(ref a);
            Console.WriteLine("a的值:x=" + a.x.ToString() + ",y=" + a.y.ToString());
            Console.WriteLine("b的值:x=" + b.x.ToString() + ",y=" + b.y.ToString());
            Console.WriteLine(a == b);
        }
        public class A
        {
            public Object x = 1;
            public object y = "s1";
        }
        public class Test
        {

            public int test()
            {
                int i = 1;
                try
                {
                    Console.WriteLine("try里面的i : " + i);
                    return i;//return语句会先压入栈里面，最后执行finally语句（有return语句，值压入栈中），最后弹出栈顶元素。
                }
                finally
                {
                    Console.WriteLine("进入finally...");
                    ++i;
                    Console.WriteLine("fianlly里面的i : " + i);
                }
            }
            public string test2()
            {
                string s = "旧值";
                try
                {
                    Console.WriteLine("try里面的s : " + s);
                    return s;
                }
                finally
                {
                    Console.WriteLine("进入finally...");
                    s= "新值";
                    Console.WriteLine("fianlly里面的s : " + s);
                }
            }
            string s = "旧值";
            public string test3()
            {
                try
                {
                    Console.WriteLine("try里面的s : " + s);
                    return s;
                }
                finally
                {
                    Console.WriteLine("进入finally...");
                    s = "新值";
                    Console.WriteLine("fianlly里面的s : " + s);
                }
            }
            public string test4(ref string s)
            {
                try
                {
                    Console.WriteLine("try里面的s : " + s);
                    return s;// 对于string，这里的返回值要特别注意
                }
                finally
                {
                    Console.WriteLine("进入finally...");
                    s = "新值";
                    Console.WriteLine("fianlly里面的s : " + s);
                }
            }

            public A test5(ref A a)
            {
                try
                {
                    Console.WriteLine("try里面的值:x=" + a.x.ToString()+ ",y="+a.y.ToString());
                    return a;
                }
                finally
                {
                    Console.WriteLine("进入finally...");
                    a.x = 2;
                    a.y="s2";
                    Console.WriteLine("fianlly里面的值:x=" + a.x.ToString() + ",y=" + a.y.ToString());
                }
            }
        }
    }
}
