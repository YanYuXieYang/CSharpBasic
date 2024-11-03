using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    internal class GenericClass
    {
        public GenericClass() {
            var list = new MyList<string>();
            Console.WriteLine("-----------添加----------");
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            Console.WriteLine($"长度：{list.Count}");
            Console.WriteLine($"容量：{list.Capacity}");
            Console.WriteLine("----------移除-----------");
            list.Remove("c");
            Console.WriteLine($"长度：{list.Count}");
            Console.WriteLine($"容量：{list.Capacity}");
            Console.WriteLine("----------foreach循环-----------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------for循环-----------");
            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public class MyList<T> : IEnumerable
        {
            private T[] _arr;
            public int Count { get; private set; }
            public int Capacity { get { return _arr.Length; } }
            public void Add(T t)
            {
                if (_arr == null)
                {
                    _arr = new T[4];
                    _arr[0] = t;
                    Count = 1;
                }
                else
                {
                    if (Count < _arr.Length)
                    {
                        _arr[Count] = t;
                        Count++;
                    }
                    else
                    {
                        var newArr = new T[_arr.Length * 2];
                        for (var i = 0; i < _arr.Length; i++)
                        {
                            newArr[i] = _arr[i];
                        }
                        newArr[Count] = t;
                        Count++;
                        _arr = newArr;
                    }
                }
            }
            public bool Remove(T t)
            {
                //var defaultVal = default(T);// 获取泛型默认值
                for (var i = 0; i < Count; i++)
                {
                    if (t.Equals(_arr[i]))
                    {
                        for (var r = i; r < Count - 1; r++)
                        {
                            _arr[r] = _arr[r + 1];
                        }
                        Count--;// Count是减一了，但是_arr[Count]这个值还在，只是访问不到。
                        return true;
                    }
                }
                return false;
            }
            public T this[int i]
            {
                get
                {
                    return _arr[i];
                }
                set
                {
                    _arr[i] = value;
                }
            }
            public IEnumerator GetEnumerator()
            {
                for (var i = 0; i < Count; i++)
                {
                    yield return _arr[i];
                }
            }
        }
    }
}
