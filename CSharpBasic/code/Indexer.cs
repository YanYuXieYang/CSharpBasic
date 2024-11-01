using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    class Indexer
    {
        public Indexer()
        {
            var r = new ReadonlyClass();
            //r.a = 2;// 无法赋值，因为是只读的

            var r2 = new MyClass(new string[] { "1","2"});
            r2.myArray[0] = "9";
            //r2.myArray = new string[] { "1", "5" };// 无法赋值，因为是只读的

            int pageCnt = 10;
            var book = new Book(pageCnt);
            for (var i = 0; i < pageCnt; i++)
            {
                book[i] = $"第{i}页：***************";
            }
            for (var i = 0; i < pageCnt; i++)
            {
                Console.WriteLine(book[i]);
            }
        }

        public class Book
        {
            private readonly string[] _pages;
            public Book(int pageCount)
            {
                _pages = new string[pageCount];
            }
            public string this[int i]
            {
                get
                {
                    return _pages[i];
                }
                set
                {
                    _pages[i] = value;// readonly为何可以赋值？
                }
            }

            //private readonly string _Name;
            //public char this[int i]
            //{
            //    get
            //    {
            //        return _Name[i];
            //    }
            //    set
            //    {
            //        _Name[i] = value;// 无法赋值，因为是只读的
            //    }
            //}
        }
        /// <summary>
        /// 这意味着myArray字段是只读的，也就是说一旦在构造函数中初始化之后，你不能再改变它的引用
        /// （即你不能让它指向另一个数组）。但是，如果myArray是数组类型，那么它指向的数组是可以被修改的。
        /// 你可以改变数组中的元素，但是不能让myArray指向另一个数组。
        /// 如果你想创建一个真正的不可变数组，你可以使用ReadOnlyCollection<T> 来创建一个包装器，
        /// 这样你可以返回一个不允许修改的集合视图，但是你仍然可以在后台修改原始数组。
        /// </summary>
        public class MyClass
        {
            public readonly string[] myArray;
            private readonly ReadOnlyCollection<string> readonlyCollection;

            public MyClass(string[] array)
            {
                myArray = array;
                readonlyCollection = new ReadOnlyCollection<string>(myArray);
                myArray = new string[] { "1" };
            }

            public ReadOnlyCollection<string> MyReadOnlyCollection
            {
                get {
                    //myArray = new string[] { "1" }; // 无法赋值，因为是只读的
                    return readonlyCollection; }
                //set { readonlyCollection = value; }// 无法赋值，因为是只读的
            }
        }
        public class ReadonlyClass
        {
            public readonly int a = 1;
            public readonly int b;
            public ReadonlyClass()
            {
                b = 3;
            }
            public int A
            {
                get { return a; }
                //set { a = value; }// 无法赋值，因为是只读的
            }

            public int B
            {
                get { return b; }
                //set { b = value; }// 无法赋值，因为是只读的
            }
        }
    }
}