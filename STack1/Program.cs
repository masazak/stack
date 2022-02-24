using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STack1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.print();
            Console.WriteLine("");
            s.Pop();
            Console.WriteLine("after remove top item");
            s.print();
            Console.WriteLine("");
            Console.WriteLine("print top item");
            s.Peak();
            s.Clear();
            Console.WriteLine("print stack after remove its items");
            s.print();

            Stack<string> s2 = new Stack<string>();
            Console.WriteLine("");
            s2.Push("masa");
            s2.Push("maya");
            s2.Push("menna");
            s2.Push("marah");
            s2.Push("lana");
            s2.print();
            Console.WriteLine("");
            Console.WriteLine("print top item");
            s2.Peak();
            s2.Clear();
            Console.WriteLine("print stack after remove its items");
            s2.print();

        }
    }


    internal class Stack<T>
    {
        
       List<T> l=new List<T>();

        public  void print()
        {if (l.Count != 0)
            {
                for (int i =0; i < l.Count; i++)
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

            { Console.WriteLine( l[0]); }

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

    }//stack
}
