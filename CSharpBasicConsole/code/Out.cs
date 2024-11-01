using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    class Out
    {
        public Out()
        {
            Test();
        }
        public void Test()
        {
            //var result = int.TryParse(Console.ReadLine(), out int amount);
            OutFunc(out int n);
            int m;
            OutFunc(out m);
            Console.WriteLine($"n={n}, m={m}");
            n = 12;
            Console.WriteLine($"n={n}");
        }
        public void OutFunc(out int n)
        {
            n = 55;
        }
    }
}
