using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList obj = new CustomList();
            obj.AddFirst(6);
            obj.AddFirst(7);
            obj.AddLast(8);
            obj.AddLast(10);
            obj.Insert(2, 9);
            // int x = obj.Get(100);
            //bool r = obj.RemoveAt(0);
            obj.Sort();
           // Console.WriteLine(r);
            obj.display();
        }
    }
}
