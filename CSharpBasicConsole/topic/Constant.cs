using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    /// <summary>
    /// 链接：https://www.nowcoder.com/questionTerminal/3526446e424e4770a7f7d2d30c36c027

    //在C#中，下面描述错误的是（B）：[静态常量用static readonly定义]

    //A.const字段只能在该字段的声明中初始化

    //B.const和static一起修饰字段就是静态常量

    //C.readonly字段可以在声明或构造函数中初始化

    //D.const 可以用于声明方法内变量，readonly不可以
    /// </summary>
    internal class Constant
    {
        static readonly int a = 1;
        const int b = 2;
    }
}
