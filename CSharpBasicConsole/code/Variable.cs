using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    internal class VariablePersion
    {
        /// <summary>
        /// 实例变量
        /// </summary>
        int _age;
        /// <summary>
        /// 静态变量
        /// </summary>
        static string _sex;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hight">值参数</param>
        /// <param name="alias">数组元素</param>
        /// <param name="name">引用参数</param>
        /// <param name="message">输出参数</param>
        void Get(double hight, string[] alias, ref string name, out string message)
        {
            //局部变量
            string value = "";
            message = "ok";
        }
    }
}
