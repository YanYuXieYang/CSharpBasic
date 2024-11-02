using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    internal class Switch2
    {
        public Switch2() {

            for (int i = 1; i <= 3; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.Write(i.ToString());
                        break;//无break时，有编译错误，提示Case标签不能贯穿到另一个标签，不能运行
                    default:
                        Console.Write((i * 2).ToString());
                        break;
                }
            }
        }
    }
}
