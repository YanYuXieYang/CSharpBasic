using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    /// <summary>
    /// 将一个 object 类型的输入 obj转化为 int 类型
    /// </summary>
    internal class ParseObject
    {
        public ParseObject() {
            Object a = "12";
            Console.WriteLine(int.Parse(a as string));
            Console.WriteLine(ParseObject.ParseInt(a));
            //Object b = "x";
            //Console.WriteLine(ParseObject.ParseInt(b));// 异常报错
            Object c = null;
            Console.WriteLine(ParseObject.ParseInt(c));
        }
        public static int ParseInt(object obj)
        {
            return ((IConvertible)obj)?.ToInt32(null) ?? 0;
        }
    }
}
