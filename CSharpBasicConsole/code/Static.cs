using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    class Static
    {
        /// <summary>
        /// 每次都会先初始化静态变量，再初始化静态构造函数
        /// 如果是实例化类，也是每次都会先初始化变量，再初始化构造函数
        /// https://blog.csdn.net/qq_25744257/article/details/81628340
        /// 四、同时有静态成员和实例成员的大致构造过程
        ///1.执行子类静态成员初始化语句；
        ///2.执行子类静态构造函数；
        ///3.执行子类实例成员初始化语句；
        ///4.执行基类静态成员初始化语句；
        ///5.执行基类静态构造函数；
        ///6.执行基类实例成员初始化语句；
        ///7.执行基类实例构造函数；
        ///8.执行子类实例构造函数。
        /// </summary>
        public Static()
        {
            //场景1
            new B();
            //场景2
            Console.WriteLine(B.strText);
            new B();// 静态构造函数只实例化一次，后续调用不会再初始化
            Console.WriteLine(A.strText);
            new A();
            new B();
        }

        public class A
        {
            static A()
            {
                Console.WriteLine("调用了A的静态构造函数");
            }
            public A()
            {
                Console.WriteLine("调用了A的构造函数");
            }
            public static string strText = "static string A";
            public string Text = "string A";
        }
        public class B : A
        {
            public static string strText = "static string B";
            public string Text = "string B";
            static B()
            {
                Console.WriteLine("调用了B的静态构造函数");
                Console.WriteLine("静态变量值：" + strText);
            }
            public B()
            {
                Console.WriteLine("调用了B的构造函数");
            }
        }
    }
}
