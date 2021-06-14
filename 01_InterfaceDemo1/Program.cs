using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InterfaceDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> ma = new List<int>();
            //ma.Add(158);
            //ma.Add(148);
            //ma.Add(157);
            //ma.Add(155);
            //foreach (var item in ma)
            //{
            //    Console.WriteLine(item);
            //}

            Marks marks = new Marks();
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public class Marks:IEnumerable,IList
        {
            private double[] marks;
            public Marks()
            {
                marks = new double[3] { 12, 16, 12.2 };
            }

            public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public bool IsReadOnly => throw new NotImplementedException();

            public bool IsFixedSize => throw new NotImplementedException();

            public int Count => throw new NotImplementedException();

            public object SyncRoot => throw new NotImplementedException();

            public bool IsSynchronized => throw new NotImplementedException();

            public int Add(object value)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(object value)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(Array array, int index)
            {
                throw new NotImplementedException();
            }

            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    yield return marks[i];
                }
            }

            public int IndexOf(object value)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, object value)
            {
                throw new NotImplementedException();
            }

            public void Remove(object value)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}
