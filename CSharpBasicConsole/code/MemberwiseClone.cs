﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    /// <summary>
    /// 浅表副本
    /// 如果原始对象中的字段是值类型，则它们被复制了一份；如果字段是引用类型，则复制的只是引用，
    /// 原始对象和拷贝对象中的引用类型字段将指向同一个对象实例。
    /// </summary>
    class MemberwiseClone
    {
        class ExampleClass
        {
            public int Value;
            public ExampleClass NestedClass;

            public ExampleClass ShallowCopy()
            {
                //创建浅表副本
                return (ExampleClass)this.MemberwiseClone();
            }
        }
        public MemberwiseClone()
        {
            ExampleClass original = new ExampleClass();
            original.Value = 10;
            original.NestedClass = new ExampleClass();

            ExampleClass shallowCopy = original.ShallowCopy();

            Console.WriteLine($"Original Value: {original.Value}, Shallow Copy Value: {shallowCopy.Value}");
            Console.WriteLine($"Original NestedClass: {original.NestedClass}, Shallow Copy NestedClass: {shallowCopy.NestedClass}");

            Console.WriteLine(ReferenceEquals(original,shallowCopy));
            Console.WriteLine(ReferenceEquals(original.NestedClass, shallowCopy.NestedClass));
            Console.WriteLine(original.Equals(shallowCopy));
            Console.WriteLine(original.NestedClass.Equals(shallowCopy.NestedClass));
            Console.WriteLine(original == shallowCopy);
            Console.WriteLine(original.NestedClass==shallowCopy.NestedClass);

            shallowCopy.Value++;
            Console.WriteLine($"Original Value: {original.Value}, Shallow Copy Value: {shallowCopy.Value}");
        }
      
    }
}
