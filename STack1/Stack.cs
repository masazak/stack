using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STack1
{
    internal class Stack<T>
    {
        List<T> l = new List<T>();

        public void print()
        {
            if (l.Count != 0)
            {
                for (int i = 0; i < l.Count; i++)
                    Console.WriteLine(l[i]);
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
        }
        public void Push(T item)
        {
            l.Insert(0, item);


        }

        public void Pop()
        {
            if (l.Count != 0)
            {
                Console.WriteLine("item in top and will remove :{0}", l[0]);
                l.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
        }

        public void Peak()
        {
            if (l.Count != 0)

            { Console.WriteLine(l[0]); }

            else
            {
                Console.WriteLine("stack is empty");
            }

        }

        public void Clear()
        {
            //for (int i = l.Count - 1; i >= 0; i--)
            //{
            //    l.RemoveAt(i);
            //}
            l.Clear();
        }
    }
}
