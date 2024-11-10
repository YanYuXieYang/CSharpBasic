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
            RegexIsMatch(input, pattern);
            //isMatch为true

            //但是,如果将定位符去掉的话
            input = "12345abc";
            pattern = @"\d*";
            RegexIsMatch(input, pattern);
            //isMatch还为true
            //这是因为IsMatch的作用是看字符串input中如果有一个满足pattern条件的,就直接返回true。
            //也就是说,如果input中如果有数字,就满足返回true的条件了。
            //即时input = "asdf",对于IsMatch也是符合规则的,因为*表示有0个或者多个,因此还是返回true。

            Console.WriteLine("----分隔线-----");

            /*
            input = "asdf";
            pattern = @"\d*";
            RegexIsMatch(input, pattern);

            input = "汉字";
            pattern = @"\w+";// \w 包括汉字
            RegexIsMatch(input, pattern);

            input = "This is a test string with some words.";
            pattern = @"\btest\b";// 单词的开始和结束
            RegexIsMatch(input, pattern);

            input = "This is a a_中文1 string with some words.";
            pattern = @"\ba_中文1\b";
            RegexIsMatch(input, pattern);

            input = "asdf";
            pattern = @"^b";// ^a: 只有当"a"是字符串的第一个字符时,匹配才会成功‌
            RegexIsMatch(input, pattern);

            input = "abcd";
            pattern = @"b+";// 
            RegexIsMatch(input, pattern);

            input = "abcd";
            pattern = @"b?e?";// 
            RegexIsMatch(input, pattern);

            input = "abcd";
            pattern = @"b{1,}";// 
            RegexIsMatch(input, pattern);

            input = "abcd";
            pattern = @"b{0,}";// 
            RegexIsMatch(input, pattern);

            input = "abbcd";
            pattern = @"b{2,}";// 
            RegexIsMatch(input, pattern);

            pattern = "[a-z0-9A-Z_]"; // 正则表达式
            input = "Example_string123 WITH numbers 456";
            RegexIsMatch(input, pattern);
            */

            Console.WriteLine("----abbcd b?分隔线-----");
            input = "abbcd";
            pattern = @"b?";//  true
            RegexIsMatch(input, pattern);
            Console.WriteLine("----abbcd b{2,}?分隔线-----");
            input = "abbcd";
            pattern = @"b{2,}?";//  true
            RegexIsMatch(input, pattern);

            /*
            假设有一个字符串“aaa”,我们想要匹配至少2个连续的“a”字符,但尽可能少地匹配：
            使用a{2,}：会匹配所有的“aaa”,因为至少需要2个“a”。
            使用a{2,}?：只会匹配2个“aa”,因为{2,}?会尽可能少地匹配,满足至少2个“a”的要求即可。
             */
            Console.WriteLine("----分隔线-----");
            input = "aaa";
            pattern = @"a{2,}";//  
            RegexIsMatch(input, pattern);
            // 使用正则表达式匹配所有符合条件的字符
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----aaa a{2,}分隔线-----");
            pattern = @"a{2,}?";//  
            RegexIsMatch(input, pattern);
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----aaa a{2,}?分隔线-----");
            pattern = @"a{2,}?";//  
            RegexIsMatch(input, pattern);
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            
            Console.WriteLine("----aaa a*?分隔线-----");
            pattern = @"a*?";//  
            RegexIsMatch(input, pattern);
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----aaa a+?分隔线,输出为何不是一个a ？-----");
            pattern = @"a+?";//  输出的是a a a ？
            RegexIsMatch(input, pattern);
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("----aaa a??分隔线-----");
            pattern = @"a??";//  
            RegexIsMatch(input, pattern);
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

            Console.WriteLine("----分隔线-----");
            input = "a.b";
            pattern = @"a.b";//  
            RegexIsMatch(input, pattern);
            Console.WriteLine("----分隔线-----");
            input = "a3b";
            RegexIsMatch(input, pattern);
            Console.WriteLine("----分隔线-----");
            input = "ab";
            RegexIsMatch(input, pattern);
            Console.WriteLine("----分隔线-----");
            input = "a43b";
            RegexIsMatch(input, pattern);

            // 只想匹配简体汉字,可以使用范围
            Console.WriteLine("----分隔线-----");
            input = "汉字";
            pattern = @"[\u4e00-\u9fff]+";//  
            RegexIsMatch(input, pattern);
            // 只想匹配简体汉字,可以使用范围。\u9fa5表示unicode表中汉字的尾
            Console.WriteLine("----分隔线-----");
            input = "汉字";
            pattern = @"^[\u4e00-\u9fa5]{1,}$";//  
            RegexIsMatch(input, pattern);
            // 括号可以将正则表达式的一部分组合成一个整体
            Console.WriteLine("----分隔线-----");
            input = @"\u4e00-\u9fff";
            pattern = @"(\u4e00-\u9fff)+";//  False ?
            RegexIsMatch(input, pattern);

            Console.WriteLine("----分隔线-----");
            input = "１２３";//全角数字123,unicode字符
            pattern = @"\d+";//  .NET默认使用的是unicode匹配模式
            RegexIsMatch(input, pattern);//True
            Console.WriteLine(Regex.IsMatch(input, pattern, RegexOptions.ECMAScript));//False //ECMAScript表示匹配ASCII字符
            pattern = @"[0-9]+";//  准确匹配ASCII字符,但不包含unicode字符
            RegexIsMatch(input, pattern);//False
            pattern = @"[０-９]+";//  全角数字匹配
            RegexIsMatch(input, pattern);//True

            Console.WriteLine("----分隔线-----");
            input = "xzx12_小豆子学堂";
            pattern = @"^\w+$";//  .NET默认使用的是unicode匹配模式
            RegexIsMatch(input, pattern);//True
            Console.WriteLine(Regex.IsMatch(input, pattern, RegexOptions.ECMAScript));//False //ECMAScript表示匹配ASCII字符

            input = "This is a test string with some words.";
            pattern = @"\btest";// 单词的开始和结束
            RegexIsMatch(input, pattern);//True

            input = "This is a a_中文1 string with some words.";
            pattern = @"a_中文\b";
            RegexIsMatch(input, pattern);//False

            input = "1";
            pattern = @"\d{2,4}";
            RegexIsMatch(input, pattern);//

            input = "4444";
            pattern = @"\d{2,4}";
            RegexIsMatch(input, pattern);//

            // 验证合法url地址
            input = "h://w";
            pattern = @"^[a-zA-Z0-9]+://.+$";
            RegexIsMatch(input, pattern);//true 

            input = "a1b3c345";
            pattern = @"[0-9]+";
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }

            // 分组
            input = "tom@163.com";
            pattern = @"(.+)@(.+)";
            Match match2 = Regex.Match(input, pattern);
            Console.WriteLine("用户名={0}, 域名={1}",
                match2.Groups[1].Value, match2.Groups[2].Value);


            #region 例17：提取字符串中的IP地址,端口号及服务类型
            //192.168.10.5[port=21,type=ftp]”,这个字符串表示IP地址为192.168.10.5的服务器的21端口提供
            //的是ftp服务,其中如果",type=ftp”部分被省略,则默认为http服务。请用程序解析此字符串,
            //然后打印出“IP地址为***的服务器的*** 端口提供的服务为***”
            //string msg ="192.168.10.5[port=21,type=ftp]";
            string msg = "192.168.10.5[port=21,type=ftp]";
            //下面.+实际能把非IP形式字符串也能匹配出来
            match2 = Regex.Match(msg,
                @"(?:.+)\[port=([0-9]{2,5})(,type=(.+))?\]");
            Console.WriteLine("ip:{0}", match2.Groups[1].Value);
            Console.WriteLine("port:{0}", match2.Groups[2].Value);
            Console.WriteLine("services:{0}",
                match2.Groups[4].Value.Length == 0 ? "http" : match2.Groups[4].Value);
            #endregion

            #region 提取出月份
            /*从Auguat  24  , 1982  ”中提取出月份Auguat、24、1982来。
             * @"^([a-zA-Z]+)\s*([0-9]{2})\s*,\s*([0-9]{4})\s*$"进行匹配。
             * 月份和日之间是必须要有空格分割的,所以使用空白符号“\s"匹配所有的空白字符,
             * 此处的空格是必须有的,所以使用“+"标识为匹配1至多个空格。之后的“,”
             * 与年份之间的空格是可有可无的,所以使用“*”表示为匹配0至多个*/
            //第一种写法
            string date = "Auguat  24  , 1982 ";
            match2 = Regex.Match(date,
                @"^([a-zA-Z]+)\s*([0-9]{2})\s*,\s*([0-9]{4})\s*$");//完整匹配
            for (int i = 0; i < match2.Groups.Count; i++)
            {
                Console.WriteLine(match2.Groups[i].Value);
            }
            Console.WriteLine("-------");
            //第2种写法：
            MatchCollection matches = Regex.Matches(date,"[a-zA-Z0-9]+");//这种匹配到多个
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
            #endregion
        }

        private void RegexIsMatch(string input, string pattern)
        {
            Console.WriteLine("input={0}, pattern={1}, IsMatch: {2}", 
                input, pattern, Regex.IsMatch(input, pattern));
        }
    }
}
