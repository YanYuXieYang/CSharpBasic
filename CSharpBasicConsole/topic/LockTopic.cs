using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    /// <summary>
    /// 不会发⽣死锁，死锁通常发生在两个或多个线程互相等待对方释放锁而无法继续执行的情况。
    /// 在这段代码中，只有一个线程持有锁，并且没有其他线程参与，因此不存在死锁的可能性‌。
    /// 这段代码主要是递归调用的深度，可能会导致栈溢出。
    /// </summary>
    internal class LockTopic
    {
        public LockTopic() {
            int count = 3;
            test(count);// 不会死锁
            StringBuilder sb = new StringBuilder();
            sb.Append("1");
            sb.Append("2");
            sb.Append("3");
            test2(sb);// 不会死锁
            int[] ints = { 1, 2, 3 };
            test3(ints, ints.Length);// 不会死锁
        }
        public void test3(int[] ints, int length)
        {
            lock (this)
            {
                if (length > 2)
                {
                    length --;
                    test3(ints, length);
                }
            }
        }
        public void test2(StringBuilder sb)
        {
            lock (this)
            {
                if (sb.Length > 2)
                {
                    sb.Remove(sb.Length-1, 1);
                    test2(sb);
                }
            }
        }
        public void test(int i)
        {
            lock (this)
            {
                if (i > 2)
                {
                    i--;
                    test(i);
                }
            }
        }
    }
}
