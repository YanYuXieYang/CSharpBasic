using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    /// <summary>
    /// 多态在 C# 中一般是通过重载和重写来达到的
    /// </summary>
    class Polymorphic
    {
        /// <summary>
        /// 重载多态
        /// 重载同一个类型里，方法名相同，但参数不同，这时请注意，返回值不是决定是不是方法重载的依据。
        /// 参数列表个数或类型不一样，就形成了重载
        /// 比如最见常的 Console.WriteLine，就有18种重载之多
        /// </summary>
        public class OverLoad
        {
            static int Add(int a, int b)
            {
                return a + b;
            }
            static double Add(double a, double b)
            {
                return a + b;
            }
            static DateTime Add(DateTime date)
            {
                return date.AddDays(1);
            }
        }

        /// <summary>
        /// 重写 override
        /// </summary>
        public class ReWrite
        {

        }
    }
}
