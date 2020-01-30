using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    public class Node
    {
        public Object data;
        public Node next;

        public Node()
        {
        }

        public Node(Object val)
        {
            //Node new_node = new Node();
            this.data = val;
            this.next = null;

        }
    }

}
