using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    internal class Func
    {
        ~Func() {
            Console.WriteLine();
        }
        public Func()
        {
            Show(1, 2);

            // 返回值有多个，用元组
            var result1 = Create1();
            Console.WriteLine(result1.i);
            Console.WriteLine(result1.s);
            var result2 = Create2();
            Console.WriteLine(result2.Item1);
            Console.WriteLine(result2.Item2);

            /* 扩展方法
             * 扩展方法也会被继承在子类中的，本质上不是继承下来的，而是在调用 Show 方法时，
             * 编译器首先会在类型本身上找对应的方法，如果没有，就会找父类；如果还没有就看有没有扩展方法；
             * 如果还没有，就看父类有没有这个名字的扩展方法。
             * 当然如果定义的扩展方法与类型本身中的扩展方法签名相同，那类型本身的方法优先级是高的，
             * 所以永远不会调用到他的同名扩展方法了。
             * */
            var cclass = new CClass(123);
            Console.WriteLine(cclass.Show());// 静态类中的 Show 扩展而来
            var ccclass = new CChildClass(567);
            Console.WriteLine(ccclass.Show());
            ccclass=null;
            Console.WriteLine(ccclass?.Show());
            Console.WriteLine("--end Func--");
        }
        static (int i, string s) Create1()
        {
            return (1, "abc");
        }
        static (int, string) Create2()
        {
            return (1, "abc");
        }
        static void Show(params int[] ints)// 二义性，永远调用不到
        {
            Console.WriteLine("动态参数方法");
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }
        }
        static void Show(int a, int b)
        {
            Console.WriteLine("普通参数方法");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        /// <summary>
        /// in 输入参数，也可以叫只读参数，加了 in 后，i 在方法中不可以被修改。
        /// </summary>
        /// <param name="i"></param>
        static void InMethod(in int i)
        {
            //i = 100;// 修改会报错
            Console.WriteLine(i);
        }
    }

    /// <summary>
    /// 必须放在顶部静态类
    /// </summary>
    public static class CClassExpant
    {
        public static int Show(this CClass c)// 扩展方法要求第一个参数必须是this加上要扩展的类型
        {
            Console.WriteLine(c.I);
            return c.I;
        }
    }

    public class CClass
    {
        public CClass(int i)
        {
            I = i;
        }
        public int I { get; set; } 
    }

    public class CChildClass : CClass
    {
        public CChildClass(int i) : base(i)
        {
            I = i;
        }
    }
}
