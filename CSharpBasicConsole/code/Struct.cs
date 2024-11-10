using CSharpBasic.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    public struct MyStruct
    {
        public int MyField; // 默认private

        public void MyMethod() // 显式声明为public
        {
            // 方法实现
        }
        public MyStruct()
        {
        }
        public MyStruct(int val)
        {
        }
    }
}
