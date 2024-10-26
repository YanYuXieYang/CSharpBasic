using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpBasic.code
{
    public class boxing_unboxing
    {
        public static void Boxing()
        {
            int num1 = 1;
            object numObj = num1;
        }
        public static void UnBoxing()
        {
            object numObj = 1;
            int num2 = (int)numObj;
        }
    }
    public class Test
    {
        public void Test001()
        {
            ArrayList arrayList = new ArrayList();
            Stopwatch s = new Stopwatch();
            s.Start();//--开始计时
            for (int i = 0; i < 40000000; i++)
            {
                arrayList.Add(i);//这里发生了装箱的操作，将int装载成object（进行了40000000次的装箱）
            }
            s.Stop(); //结束计时
            Console.WriteLine("装箱耗费时间：" + s.Elapsed);
        }
        public void Test002()
        {
            List<int> list = new List<int>();
            Stopwatch s = new Stopwatch();
            s.Start();//-开始计时
            for (int i = 0; i < 40000000; i++)
            {
                list.Add(i);// list 默认只存放int型，所以没有装拆操作（进行了40000000次的装箱）
            }
            s.Stop(); //结束计时
            Console.WriteLine("不装箱耗费时间：" + s.Elapsed);
        }
    }
}
