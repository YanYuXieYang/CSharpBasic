using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    /// <summary>
    /// 分部类
    /// 分部类用 partial，分部类的意思是可以把一个类分在两个.cs 文件中定义，
    /// 同时其中可以定义分部方法，分部类只是语法上，在编译的时候会被合并。
    /// 分开的好处是如果同一个类被两个人定义，互不打扰，或者同一个类中成员分两类功能，
    /// 可以分开定义，看起来比较集中，比如 WinForm 程序，自动生成的成员会在一个文件中定义，
    /// 自己写的成员会在一个文件中，可以让开发人员更专注自己写的功能。
    /// 每个部分必须使用partial关键字，并且所有部分必须在同一个命名空间中。
    /// b.cs如下,a.cs在另一个文件AClass.cs中
    /// </summary>
    public partial class EClass
    {
        public int E2 { get; set; } = 2;
        //partial void Show(string message);
    }
}
