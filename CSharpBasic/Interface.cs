using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    /// <summary>
    /// 接口用于定义做什么，抽象类用于定义是什么
    /// 在 C# 8.0 以前，接口 interface 只有四种成员：方法，属性，事件，索引器
    /// 在 C# 11 这个版中，增加静态成员，接口中还可以有实例化方法和运算符重载
    /// </summary>
    public interface interf
    {
        void Method();
        string Property { get; set; }
        string this[int i] { get; set; }
        event EventHandler Event;
    }
    /*
    /// <summary>
    /// C# 11.0
    /// </summary>
    public interface ITest
    {
        public static string StaticProperty01 { get; set; } = "ITest静态属性";
        public static readonly string StaticField01 = "ITest静态只读字段";
        public const string StaticField02 = "ITest静态常量";
        //静态事件
        public static event Handler? StaticEvent;

        public static void StaticMethod()
        {
            Console.WriteLine("ITest静态方法");
        }
        static ITest()
        {
            Console.WriteLine("ITest静态构造函数");
        }
    }
    */
}
