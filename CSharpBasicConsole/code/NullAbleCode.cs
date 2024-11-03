using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    internal class NullAbleCode
    {
        public NullAbleCode() {
            int? i1 = null;
            int i2 = i1 ?? 10;
            Console.WriteLine(i1);//结果是空
            Console.WriteLine(i2);//结果是10
            Console.WriteLine("--end NullAbleCode--");
        }
    }
}
