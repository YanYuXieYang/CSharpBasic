using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    /// <summary>
    /// ]、派生类B构造的时候会调用基类A的构造函数，所以会执行PrintFields（）；
    /// 2、因为PrintFields是虚方法，所以基类调用派生类的PrintFields方法，因此产生输出。
    /// 3、x是在定义的时候初始化的，而y是在构造函数中赋值的，所以x会在调用构造函数之前被赋值。
    /// 4、派生类构造函数会在构造自身之前调用基类构造函数，因此执行PrintFileds方法的时候y没有被赋值，默认初值为0。
    /// </summary>
    public class Extend1
    {
        public Extend1()
        {
            var b = new B();
            b.PrintFields();
        }

        class A
        {
            public A()
            {
                PrintFields();
            }
            public virtual void PrintFields() {
                Console.WriteLine("A.PrintFields()");
            }
        }
        class B : A
        {
            int x = 1;
            int y;
            public B()
            {
                y = -1;
            }
            public override void PrintFields()
            {
                /* 结果：
                 * x=1,y=0
                 * x=1,y=-1
                 */
                Console.WriteLine("x={0},y={1}", x, y);
            }
        }
    }
}
