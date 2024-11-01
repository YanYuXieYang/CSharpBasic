using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    /// <summary>
    /// 运算符。常用：
    /// 算述运算符：x * y, x / y, x % y ,x + y, x – y
    /// 关系运算符：x < y, x > y, x <= y, x >= y, x == y, x != y
    /// 条件运算符：x && y , x || y , c ? t : f (三元)
    /// </summary>
    internal class Operator
    {
        public Operator()
        {
            /*自运算
             * +x为原值。-x是取反操作符，表示正值变负值或负值变正值。
             */

            int x = -5, y=0,z=2;
            int positiveX = +x; // positiveX 的值为 -5
            int negativeX = -x; // negativeX 的值为 5
            int positiveZ = +z; 
            int negativeZ = -z; 
            Console.WriteLine($"Positive x: {positiveX}"); // 输出: Positive x: -5
            Console.WriteLine($"Negative x: {negativeX}"); // 输出: Negative x: 5
            Console.WriteLine("+z: {0}", positiveZ); // 输出: z: 2
            Console.WriteLine("-z: {0}", negativeZ); // 输出: z: -2
            Console.WriteLine("+y: {0}", +y); // 输出: y: 0
            Console.WriteLine("-y: {0}", -y); // 输出: y: 0
        }

    }
}
