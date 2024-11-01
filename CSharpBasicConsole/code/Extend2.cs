using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    public class Extend2
    {
        public Extend2()
        {
            // 使用
            SubClass sub = new SubClass();
        }

        class BaseClass
        {
            public BaseClass()
            {
                Console.WriteLine("基类无参构造函数被调用");
            }

            public BaseClass(int value)
            {
                Console.WriteLine($"基类有参构造函数被调用: {value}");
            }
        }

        class SubClass : BaseClass
        {
            public SubClass() : base(42) // 显式调用基类的有参构造函数
            {
                Console.WriteLine("子类无参构造函数被调用");
            }
        }
    }
}
