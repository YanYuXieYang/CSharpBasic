using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    /// <summary>
    /// 闭包
    /// </summary>
    internal class ClosureFunc
    {
        public ClosureFunc()
        {
            Console.WriteLine(GetClosureFunction()(30));
        }

        /// <summary>
        /// 委托internalAdd就是一个闭包，引用了外部函数GetClosureFunction作用域中的变量val。
        /// </summary>
        /// <returns></returns>
        static Func<int, int> GetClosureFunction()
        {
            int val = 10;
            Func<int, int> internalAdd = x => x + val;

            Console.WriteLine(internalAdd(10));

            val = 30;
            Console.WriteLine(internalAdd(10));

            return internalAdd;
        }
    }
}
