using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    /// <summary>
    /// 由于精度低的类型会自动转化为精度高的数值,因此整形会自动转化为浮点型
    /// </summary>
    internal class Float2
    {
        public Float2()
        {
            int r = 3;
            const float pi = 3.14f;
            Console.WriteLine("圆的周长为{0}", 2 * r * pi);// 输出：圆的周长为18.84
        }
    }
}
