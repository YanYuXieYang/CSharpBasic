using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
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

            int n = 2;
            bool b = true;
            Console.WriteLine("n!: {0}", n!); // 输出: n!: 2  //具体看下面的null 容忍操作符
            Console.WriteLine("^n: {0}", ^n); // 输出: ^n: ^2
            Console.WriteLine("~n: {0}", ~n); // 输出: ~n: -3
            Console.WriteLine("!b: {0}", !b); // 输出: !b: False
            Console.WriteLine("[abc123]!: {0}", "abc123"!); // 输出: abc123

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var range = numbers[1..3]; // 获取从索引1到3(不含)的元素，即{2, 3}
            foreach( int i in range ) Console.Write(i);// 输出: 23
            Console.WriteLine();

            /*
             * null 容忍操作符(null-forgiving operator)# ，非空断言运算符
             * 来自于 C#8 的新特性，比较冷门，国内的翻译 C#8 的文章基本都没有提到。它是一个非常有用的特性。
             * 官方文档：! (null-forgiving) operator (C# reference)
             * 它的主要作用就是告诉编译器，变量不可能为 null，这对于有代码洁癖的人来说非常有用。
             */
            string msg = "ab";// null或string.Empty都会执行报错！
            string upperCaseMsg = msg!.ToUpper();
            Console.WriteLine(string.Empty == null); // string.Empty == null输出: False
            Console.WriteLine(string.Empty.Equals(null)); // string.Empty.Equals(null)输出: False

            // 运算符优先级
            Console.WriteLine("算术运算符：{0}", 2*9/3%5+7-3*3); // 输出：-1
        }

    }
}
