using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custom;

namespace Custom
{
   
    public class CustomList : ICustomList
    {
        static Node head;
        
       public void AddFirst(Object data)
        {
            Node node = new Node(data);
            if (head == null)
            {

                head = node;
            }
            else
            {
                node.data = data;

                node.next = head;
                head = node;
            }
        }
        public void AddLast(Object data)
        {
            Node new_node = new Node(data);
            if (head == null)
            {
               
                head = new_node;
            }
            else
            {
                Node start = head;
               
                while (start.next != null)
                {
                   
                    start = start.next;
                }
             start.next = new_node;
            }
        }
        public void Insert(int index, Object data)
        {
            Node node = new Node(data);
            Node start = head;
            int count = 0;
            while(start.next!=null &&(count)!=index)
            {
                count++;
                start = start.next;
               // Console.WriteLine(start.data + " count" + count);
            }
            node.next = start.next;
            start.next = node;
        }
        public int IndexOf(Object item)
        {
            Node start = head;
            int count = 0;
            while(start.next!=null && (start.data) != item)
            {
                start = start.next;
                count++;
            }
            return count;
        }
        public bool Contains(Object item)
        {
            Node start = head;
            bool res = false;
            while(start.next!=null   )
            {
                if (start.data == item)
                {
                    res = true;
                    break;
                }
                start = start.next;
            }
            return res;
        }
        public void display()
        {
            Node start = head;
            while (start.next != null)
            {
                Console.WriteLine(start.data + " ");
                start = start.next;
            }
            Console.WriteLine(start.data + " ");
        }
        public Object Get(int index)
        {
            Node start = head;
            int count = 0;
            while (start.next != null&& count!=index)
            {
                count++;     
                start = start.next;
            }
            return start.data;
        }
        public void Sort()
        {
            int count = 0;
            Node start = head;
            while(start.next!=null)
            {
                start = start.next;
                count++;
            }
           
            Object[] array = new Object[count+1];
            start = head;
            count = 0;
            while (start.next != null)
            {
                array[count] = start.data;
                start = start.next;
                count++;
            }
            Array.Sort(array);
            start = head;
            count = 0;
            while(start.next!=null)
            {
                start.data = array[count];
                start = start.next;
                count++;
            }

        }
        public bool Remove(Object data)
        {
            Node start = head;
            bool flag = false;
            Node temp = head;
            while(start.next!=null && flag==false )
            {
                if (start.data != data)
                {
                    temp = start;
                    start = start.next;
                }
                else
                {
                    
                    flag = true;
                }
            }
            if(flag==true)
            {
                if (temp == head)
                {
                    head = temp.next;
                }
                else
                {
                    temp.next = start.next;
                }
            }
            return flag;
        }
        public bool RemoveAt(int index)
        {
            Node start = head;
            int count = 0;
           bool flag = false;
            Node temp = head;
            while (start.next!=null && flag==false)
            {
                if (index != count)
                {
                    temp = start;
                    start = start.next;
                    count++;
                        }
                else
                {
                    flag = true;
                    
                }
            }
            if(flag)
            {
                if(count==0)
                {
                    head = temp.next;
                }
                temp.next = start.next;
            }
            return flag;
        }


    }
}
