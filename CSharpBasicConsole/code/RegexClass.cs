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
            string s = "12345";
            string pattern = @"^\d*$"; //正则表达式
            Console.WriteLine(Regex.IsMatch(s, pattern));
            //isMatch为true

            //但是，如果将定位符去掉的话
            s = "12345abc";
            pattern = @"\d*";
            Console.WriteLine(Regex.IsMatch(s, pattern));
            //isMatch还为true
            //这是因为IsMatch的作用是看字符串s中如果有一个满足pattern条件的，就直接返回true。
            //也就是说，如果s中如果有数字，就满足返回true的条件了。
            //即时s = "asdf"，对于IsMatch也是符合规则的，因为*表示有0个或者多个，因此还是返回true。
            s = "asdf";
            pattern = @"\d*";
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "汉字";
            pattern = @"\w+";// \w 包括汉字
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "This is a test string with some words.";
            pattern = @"\btest\b";// 单词的开始和结束
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "This is a a_中文1 string with some words.";
            pattern = @"\ba_中文1\b";
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "asdf";
            pattern = @"^b";// ^a: 只有当"a"是字符串的第一个字符时，匹配才会成功‌
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "abcd";
            pattern = @"b+";// 
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "abcd";
            pattern = @"b?e?";// 
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "abcd";
            pattern = @"b{1,}";// 
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "abcd";
            pattern = @"b{0,}";// 
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "abbcd";
            pattern = @"b?";//  true ?
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "abbcd";
            pattern = @"b{2,}";// 
            Console.WriteLine(Regex.IsMatch(s, pattern));

            s = "abbcd";
            pattern = @"b{2,}?";//  true ?
            Console.WriteLine(Regex.IsMatch(s, pattern));
            /*
            假设有一个字符串“aaaaa”，我们想要匹配至少3个连续的“a”字符，但尽可能少地匹配：
            使用a{3,}：会匹配所有的“aaaaa”，因为至少需要3个“a”。
            使用a{3,}?：只会匹配3个“aaa”，因为{3,}?会尽可能少地匹配，满足至少3个“a”的要求即可。
             */
        }
    }
}
