using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    class Equals
    {
        /// <summary>
        /// https://www.cnblogs.com/johnyang/p/15368737.html#_label0_5
        /// 对于字符串类型，Equals方法和==运算符在判断两个字符串是否一致时是等价的，
        /// 因为C#中的字符串是引用类型，但是字符串类型在底层会被优化为常量，
        /// 即使用相同的字符串值创建的字符串变量在内存中会使用同一个实例，
        /// 因此它们的引用地址也相同，当判断两个字符串是否相同时，==运算符也会返回true。
        /// </summary>
        public Equals()
        {
            Equals_String();
            Equals_Object();
            Equals_Class();
            Equals_DiffType();
            Equals_Virual();
            Equals_NaN();
        }
        void Equals_String()
        {
            Console.WriteLine(">>>Equals_String:");
            string s1 = "abc";
            string s2 = "abc";
            string s3 = s1;
            Console.WriteLine(s1.Equals(s2));//return True;
            Console.WriteLine(s1 == s2);//return True; // string的底层特殊性
            Console.WriteLine(s1 == s3);//return True;

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
        }
        void Equals_Object()
        {
            Console.WriteLine(">>>Equals_Object:");
            object x = 5;
            object y = 5;
            Console.WriteLine(x.Equals(y));//return True;
            Console.WriteLine(x == y);//return false;
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(y.GetHashCode());

            //ReferenceEquals(x, y);
        }
        class Foo { public int x; }
        void Equals_Class()
        {
            Console.WriteLine(">>>Equals_Class:");
            Foo f1 = new Foo { x = 5 };
            Foo f2 = new Foo { x = 5 };
            Console.WriteLine(f1.Equals(f2));//return false;
            Console.WriteLine(f1 == f2);//return false;
            Console.WriteLine(f1.GetHashCode());
            Console.WriteLine(f2.GetHashCode());
        }
        void Equals_DiffType()
        {
            Console.WriteLine(">>>Equals_DiffType:");
            int x = 5;
            double y = 5;
            Console.WriteLine(x.Equals(y));//return false
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(y.GetHashCode());
        }
        void Equals_Virual()
        {
            Console.WriteLine(">>>Equals_Virual:");
            Foo f1 = null;
            Foo f2 = null;
            Console.WriteLine(f1 == f2);//true

            object x = 3, y = 3;
            Console.WriteLine(x.Equals(y));//true
            y = null;
            Console.WriteLine(x.Equals(y));//false
            x = null;
            //Console.WriteLine(x.Equals(y));// 虚函数，如果调用者本身就是null，那么将抛出异常。
        }
        ////虚方法默认为这样的：
        //public virtual bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    if (GetType() != obj.GetType()) return false;
        //    if (obj == this) return true;
        //}

        /// <summary>
        /// double类型的==运算符强制任何一个NaN和任何一个数都不相等，对于另一个NaN也不相等
        /// 而Equals，需要遵守一些规定，比如：
        ///         x.Equals(x) must always return true.
        /// </summary>
        void Equals_NaN()
        {
            Console.WriteLine(">>>Equals_NaN:");
            double x = double.NaN;
            Console.WriteLine(x == x);//false
            Console.WriteLine(x.Equals(x));//true
            double y = double.NaN;
            Console.WriteLine(x == y);//false //==运算符强制任何一个NaN和任何一个数都不相等，对于另一个NaN也不相等
            Console.WriteLine(x.Equals(y));//true
        }
    }
}
