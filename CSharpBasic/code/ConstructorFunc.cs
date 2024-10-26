using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    /// <summary>
    /// 1.在C#中，创建子类实例时会自动调用父类的构造函数。‌
    /// 2.在C#中，当创建一个子类的实例时，子类的构造函数会自动调用父类的构造函数。
    ///     这是因为在子类的构造函数中，默认情况下，会隐式地调用父类的无参构造函数。
    ///     如果父类没有定义无参构造函数，编译器会报错。为了解决这个问题，
    ///     可以在子类构造函数中显式地使用base关键字来调用父类的特定构造函数‌
    /// </summary>
    class ConstructorFunc
    {
        // 默认调用父类无参构造函数
        public ConstructorFunc()
        {
            new Student();
        }
        public class Person
        {
            public Person()
            {
                Console.WriteLine("我是人");
            }
        }

        public class Student : Person
        {
            public Student()
            {
                Console.WriteLine("我是学生");
            }
        }

    }

    class ConstructorFunc2
    {
        // ‌显式调用父类有参构造函数‌
        public ConstructorFunc2()
        {
            new Student();
            new Student("汤姆");
        }
        public class Person
        {
            public Person()
            {
                Console.WriteLine("我是人");
            }
            public Person(string name)
            {
                Console.WriteLine("我是人,我的名字叫{0}", name);
            }
        }

        public class Student : Person
        {
            public Student() : base()
            {
                Console.WriteLine("我是学生");
            }
            public Student(string name) : base(name)
            {
                Console.WriteLine("我是学生,我的名字叫{0}", name);
            }
        }

    }
}