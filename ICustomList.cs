using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    interface ICustomList
    {
       
        void AddFirst(int data);
        void AddLast(int data);
        void Insert(int index, int data);


        int IndexOf(int item);
        bool Contains(int item);


        void display();
        int Get(int index);


        void Sort();


        bool Remove(int data);
        bool RemoveAt(int position);
    }
}
