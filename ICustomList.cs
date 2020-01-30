using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    interface ICustomList
    {
       
        void AddFirst(Object data);
        void AddLast(Object data);
        void Insert(int index, Object data);


        int IndexOf(Object item);
        bool Contains(Object item);


        void display();
      Object Get(int index);


        void Sort();


        bool Remove(Object data);
        bool RemoveAt(int position);
    }
}
