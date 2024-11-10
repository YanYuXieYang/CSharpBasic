using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    internal class AbstractClass
    {

        /// <summary>
        /// 抽象类
        /// 1.抽象类不能实例化,不能使用类名调用，只能用子类来实例化它，然后调用。
        /// 2.抽象类中可以有抽象成员和实例化成员
        /// </summary>
        public abstract class CClass
        {
            static void Main(string[] args)
            {

            }
            public abstract void Show();// 抽象类中的抽象成员.这个方法没有实现，只有签名，没有具体干什么的代码
            public void Show(string message)// 抽象类中的实例化成员
            {
                Console.WriteLine(message);
            }
        }
        public class abstractClass : CClass
        {
            public override void Show()
            {
            }
        }
        public interface IVehicle
        {
            void Start();
            void Stop();
        }
        /// <summary>
        /// 抽象类实现接口
        /// </summary>
        public abstract class Vehicle : IVehicle
        {
            public abstract void Start();
            public abstract void Stop();
        }

        public class Car : Vehicle
        {
            public override void Start()
            {
                Console.WriteLine("Car Started.");
            }

            public override void Stop()
            {
                Console.WriteLine("Car Stopped.");
            }
        }
    }
}
