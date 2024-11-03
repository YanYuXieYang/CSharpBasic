using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    /// <summary>
    /// 具体使用 AuthorAttribute 时，可以把 Attribte 除掉，直接用前面的单词，
    /// 然后括号中把必填参数跟上，可选参数可以不填。
    /// 特性的必填参数其实是在定义构造函数时的参数，可选参数是特性内定义的属性。
    /// </summary>
    internal class Attribute2 : Attribute
    {
        public Attribute2()
        {
            // 1、检查派生类是否有 MyInheritedAttribute
            var isInherited = typeof(DerivedClass).IsDefined(typeof(MyInheritedAttribute), true);
            Console.WriteLine($"Is MyInheritedAttribute inherited? {isInherited}");

            // 2、定义一个特性Attribute，用于标记方法是否已经过时
            MyClass myClass = new MyClass();
            myClass.OldMethod(); // 这将显示警告信息，因为OldMethod方法已过时
            myClass.NewMethod(); // 这是推荐使用的方法

            // 以命名参数的方式调用方法
            Console.WriteLine("{0}", Sub(b: 10));
            Console.WriteLine("{0}", Sub(b: 2, a: 3));
        }
        #region 学发中心
        

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = true, Inherited = true)]
        public class AuthorAttribute : Attribute
        {
            public AuthorAttribute(string name, string version)
            {
                Name = name;
                Version = version;
            }
            public string Name { get; init; }
            public string Version { get; init; }
            public string? Description { get; set; }
            public string? CreateDate { get; set; }
        }

        [Author("桂素伟", "10.0.1", CreateDate = "2022-07-01", Description = "这个类型很神奇，什么也没有")]
        [Author("张三", "10.0.1", CreateDate = "2022-07-01")]
        class A
        {
        }

        [Author("桂素伟", "1.0.1", Description = "这个枚举很神奇，什么也没有")]
        enum B
        {
        }
        int Sub(int a = 0, int b = 0)
        {
            return a - b;
        }
        #endregion


        // 定义一个特性，它的 Inherited 属性被设置为 true
        [AttributeUsage(AttributeTargets.Class, Inherited = true)]
        public class MyInheritedAttribute : Attribute
        {
            public string Value { get; }

            public MyInheritedAttribute(string value)
            {
                Value = value;
            }
        }

        // 基类使用了 MyInheritedAttribute
        [MyInheritedAttribute("BaseClass")]
        public class BaseClass
        {
        }

        // 派生类继承了 MyInheritedAttribute
        public class DerivedClass : BaseClass
        {
        }


        // 定义一个特性Attribute，用于标记方法是否已经过时
        [AttributeUsage(AttributeTargets.Method)]
        public class ObsoleteAttribute : Attribute
        {
            public string Message { get; }

            public ObsoleteAttribute(string message)
            {
                Message = message;
            }
        }

        // 定义一个带有已过时方法的类
        public class MyClass
        {
            // 使用ObsoleteAttribute特性标记了方法OldMethod，提供了一条过时警告信息
            [ObsoleteAttribute("This method is obsolete, please use NewMethod instead.")]
            public void OldMethod()
            {
                Console.WriteLine("You are calling the old method.");
            }

            public void NewMethod()
            {
                Console.WriteLine("This is the new method to use.");
            }
        }
    }
}
