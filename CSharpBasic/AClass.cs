using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    /*
     * 本节通过实例了解了各种类型的定义和使用，每种类都有其特定的使用场合，
     * 可以 new 的类型是希望有多副本，静态类是只有一份，抽象类是定义规范，
     * 让子类实现的，密封类是不让继承的，到此为止（string 就是一个密封类），
     * 分部类是方便开发用的，匿名类是现定义现使用，泛型类是把类型推迟到调用时定义，
     * 记录是一种特列类型，在输出时是有数据的，有这个好处是可以用来比较两个类型的相等性。
     */

    /// <summary>
    /// 学发中心人才云 https://te.jiker.com/skill/35?knowledge=1628
    /// 实例化类
    /// 1.在 class 可以定义的成员有常量，静态成员，字段（全局变量），构造函数，属性，
    /// 方法，事件，析构函数，索引器，运算符，以及嵌套类型.
    /// 2.类中的静态成员和常量是通过类名调用的AClass.No = "N0001"; AClass.MyType.
    /// 3.其他的是new实例化一个对象来调用.
    /// </summary>
    public class AClass
    {
        //常量
        public const string MyType = "Class";
        //静态成员
        public static string No { get; set; }
        //字段
        private string _name;
        //构造函数
        public AClass()
        {
        }
        //属性
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //方法
        public void Show()
        {
            Console.WriteLine(_name);
        }
        //事件
        public event EventHandler Showed;
        //终结器 析构函数
        ~AClass()
        {
        }
        //索引器
        public char this[int i]
        {
            get { return _name[i]; }
        }
        //运算符
        public static AClass operator +(AClass a)
        {
            return a;
        }
        //嵌套类
        public class AChildClass
        {
        }
    }

    /// <summary>
    /// 静态类 (static)
    /// 1.静态类不能实例化,类中只能定义静态成员
    /// </summary>
    public static class BClass
    {
        public static int I { get; set; } = 10;
    }
    /// <summary>
    /// 抽象类
    /// 1.抽象类不能实例化,不能使用类名调用，只能用子类来实例化它，然后调用。
    /// 2.抽象类中可以有抽象成员和实例化成员
    /// </summary>
    public abstract class CClass
    {
        public abstract void Show();// 抽象类中的抽象成员.这个方法没有实现，只有签名，没有具体干什么的代码
        public void Show(string message)// 抽象类中的实例化成员
        {
            Console.WriteLine(message);
        }
    }
    /// <summary>
    /// 密封类
    ///  密封类用关键字 sealed 定义，密封类可以用 new 实例化，使用起来和实例化类没有区别，
    ///  不一样的是它不能被继承，不能有子类。
    /// </summary>
    public sealed class DClass
    {
        //public static int a = 1;
        //public  string b;
        //public char this[int i]
        //{
        //    get { return b[i]; }
        //}
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
    /// <summary>
    /// 分部类
    /// 分部类用 partial，分部类的意思是可以把一个类分在两个.cs 文件中定义，
    /// 同时其中可以定义分部方法，分部类只是语法上，在编译的时候会被合并。
    /// 分开的好处是如果同一个类被两个人定义，互不打扰，或者同一个类中成员分两类功能，
    /// 可以分开定义，看起来比较集中，比如 WinForm 程序，自动生成的成员会在一个文件中定义，
    /// 自己写的成员会在一个文件中，可以让开发人员更专注自己写的功能。
    /// a.cs如下,b.cs在另一个文件中
    /// </summary>
    public partial class EClass
    {
        public int E1 { get; set; } = 1;
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }


}
