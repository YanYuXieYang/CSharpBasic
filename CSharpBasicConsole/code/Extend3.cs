using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    public class Extend3
    {
        public Extend3()
        {
            SubClass obj = new SubClass();
            //无效果
            //obj = null;
            //System.GC.Collect();
            // 程序结束时，obj对象将被垃圾回收，并调用析构函数
        }

        class BaseClass
        {
            public BaseClass()
            {
                Console.WriteLine("基类构造函数被调用");
            }

             ~BaseClass()
            {
                Console.WriteLine("基类析构函数被调用");
            }
        }

        class SubClass : BaseClass
        {
            public SubClass()
            {
                Console.WriteLine("子类构造函数被调用");
            }

             ~SubClass()
            {
                Console.WriteLine("子类析构函数被调用");
            }
        }
    }
}