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

            Console.ReadLine();

        }
    }


   
}
