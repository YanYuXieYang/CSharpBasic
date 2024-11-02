using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    internal class PointFixed
    {
        public PointFixed() {
            ChangePoint();
        }

        unsafe static void ChangePoint()
        {
            int i = 42;
            // 固定变量以防止垃圾收集器移动它
            int* p = &i;
            //fixed (int* p = &i)// 编译报错提示：CS0213 不能使用 fixed 语句来获取已固定的表达式的地址
            {
                Console.WriteLine(*p); // 输出 42
                *p = 10;
            }

            Console.WriteLine(i); // 输出 10，因为解锁固定区域后，i的值已更改
        }
    }
}
