using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    internal class RegexClass
    {
        public RegexClass()
        {
            //@表示\不被理解为转义字符
            //^代表定位开头
            //\d代表是0-9的数字
            //*代表0个或者多个字符
            //$代表定位结尾
            //因此以下正则表达式代表仅仅由数字组成的字符串
            string input = "12345";
            string pattern = @"^\d*$"; //正则表达式
            Console.WriteLine(Regex.IsMatch(input, pattern));
            //isMatch为true

            //但是，如果将定位符去掉的话
            input = "12345abc";
            pattern = @"\d*";
            Console.WriteLine(Regex.IsMatch(input, pattern));
            //isMatch还为true
            //这是因为IsMatch的作用是看字符串input中如果有一个满足pattern条件的，就直接返回true。
            //也就是说，如果input中如果有数字，就满足返回true的条件了。
            //即时input = "asdf"，对于IsMatch也是符合规则的，因为*表示有0个或者多个，因此还是返回true。

            Console.WriteLine("----分隔线-----");

            /*
            input = "asdf";
            pattern = @"\d*";
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "汉字";
            pattern = @"\w+";// \w 包括汉字
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "This is a test string with some words.";
            pattern = @"\btest\b";// 单词的开始和结束
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "This is a a_中文1 string with some words.";
            pattern = @"\ba_中文1\b";
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "asdf";
            pattern = @"^b";// ^a: 只有当"a"是字符串的第一个字符时，匹配才会成功‌
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "abcd";
            pattern = @"b+";// 
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "abcd";
            pattern = @"b?e?";// 
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "abcd";
            pattern = @"b{1,}";// 
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "abcd";
            pattern = @"b{0,}";// 
            Console.WriteLine(Regex.IsMatch(input, pattern));

            input = "abbcd";
            pattern = @"b{2,}";// 
            Console.WriteLine(Regex.IsMatch(input, pattern));

            pattern = "[a-z0-9A-Z_]"; // 正则表达式
            input = "Example_string123 WITH numbers 456";
            Console.WriteLine(Regex.IsMatch(input, pattern));
            */

            Console.WriteLine("----abbcd b?分隔线-----");
            input = "abbcd";
            pattern = @"b?";//  true
            Console.WriteLine(Regex.IsMatch(input, pattern));
            Console.WriteLine("----abbcd b{2,}?分隔线-----");
            input = "abbcd";
            pattern = @"b{2,}?";//  true
            Console.WriteLine(Regex.IsMatch(input, pattern));

            /*
            假设有一个字符串“aaa”，我们想要匹配至少2个连续的“a”字符，但尽可能少地匹配：
            使用a{2,}：会匹配所有的“aaa”，因为至少需要2个“a”。
            使用a{2,}?：只会匹配2个“aa”，因为{2,}?会尽可能少地匹配，满足至少2个“a”的要求即可。
             */
            Console.WriteLine("----分隔线-----");
            input = "aaa";
            pattern = @"a{2,}";//  
            Console.WriteLine(Regex.IsMatch(input, pattern));
            // 使用正则表达式匹配所有符合条件的字符
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----aaa a{2,}分隔线-----");
            pattern = @"a{2,}?";//  
            Console.WriteLine(Regex.IsMatch(input, pattern));
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----aaa a{2,}?分隔线-----");
            pattern = @"a{2,}?";//  
            Console.WriteLine(Regex.IsMatch(input, pattern));
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            
            Console.WriteLine("----aaa a*?分隔线-----");
            pattern = @"a*?";//  
            Console.WriteLine(Regex.IsMatch(input, pattern));
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----aaa a+?分隔线，输出为何不是一个a ？-----");
            pattern = @"a+?";//  输出的是a a a ？
            Console.WriteLine(Regex.IsMatch(input, pattern));
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----aaa a??分隔线-----");
            pattern = @"a??";//  
            Console.WriteLine(Regex.IsMatch(input, pattern));
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----分隔线-----");
            pattern = "test";
            input = "This is a test string";
            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("模糊匹配：找到了模式");
            }
            else
            {
                Console.WriteLine("模糊匹配：没有找到模式");
            }
        }
    }
}
