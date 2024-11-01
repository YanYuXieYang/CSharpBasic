using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    public class NewFunc
    {
        /// <summary>
        /// 1、隐藏基类成员：当你在子类中创建了一个与基类成员同名的新成员时，可以使用new关键字来隐藏基类成员。
        /// 这样，子类的成员会覆盖基类的成员，但子类的对象仍然可以通过基类的引用访问到基类的成员。
        /// </summary>
        public NewFunc()
        {
            SubClass obj = new SubClass();
            obj.MyMethod(); // 调用SubClass.MyMethod

            BaseClass objAsBase = obj;
            objAsBase.MyMethod(); // 调用BaseClass.MyMethod
        }
        public class BaseClass
        {
            public void MyMethod()
            {
                Console.WriteLine("BaseClass.MyMethod");
            }
        }
        public class SubClass : BaseClass
        {
            new public void MyMethod()
            {
                Console.WriteLine("SubClass.MyMethod");
            }
        }
    }

    public class NewFunc2
    {
        /// <summary>
        /// 2、重写基类成员：当你在子类中创建了与基类中虚方法（virtual）、抽象方法（abstract）或接口方法
        /// （interface）同名的方法时，可以使用new关键字来隐式地提供方法覆盖
        /// </summary>
        public NewFunc2()
        {
            SubClass obj = new SubClass();
            obj.MyMethod(); // 调用SubClass.MyMethod

            BaseClass objAsBase = obj;
            objAsBase.MyMethod(); // 调用BaseClass.MyMethod，因为MyMethod没有被重写
        }
        public class BaseClass
        {
            public virtual void MyMethod()
            {
                Console.WriteLine("BaseClass.MyMethod");
            }
        }

        public class SubClass : BaseClass
        {
            public new void MyMethod()
            {
                Console.WriteLine("SubClass.MyMethod");
            }
        }
    }
}
