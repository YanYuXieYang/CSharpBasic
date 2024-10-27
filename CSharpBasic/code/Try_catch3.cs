using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    class Try_catch3
    {
        public Try_catch3()
        {
            try
            {
                Test1();
            }
            catch (Exception e1)
            {
                Console.WriteLine("Try_catch3 Exception:" + e1.Message);
            }
            finally
            {
                Console.WriteLine("finally-Try_catch3");
            }
        }
        public void Test1()
        {
            try
            {
                Console.WriteLine("try-Test1");
                Test2();
            }
            finally
            {
                Console.WriteLine("finally-Test1");
            }
        }
        public void Test2()
        {
            try
            {
                Console.WriteLine("try-Test2");
                var i = 0;
                var k = 100 / i;
                Console.WriteLine(k);
            }
            finally
            {
                Console.WriteLine("finally-Test2");
            }
        }
 
    }
}
