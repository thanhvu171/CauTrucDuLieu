using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_DSLKD
{
    class Node
    {
        private Node _next;
        private float _info;

        public Node(float x)
        {
            _info = x;
            _next = null;
        }
        public float info
        {
            set { this._info = value; }
            get { return _info; }
        }
        public Node next
        {
            set { this._next = value; }
            get { return _next; }
        }
    }
    class LienKetDon
    {
        private Node
            head;
        public LienKetDon()
        {
            head = null;
        }
        public void themDau(float x)
        {
            Node p = new Node(x);
            p.next = head;
            head = p;
        }
        public void inDanhSach()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write($"{p.info} ");
                p = p.next;
            }
        }
        public Node timNutCoGTLN()
        {
            Node max = head;
            Node n = head.next;
            while (n != null)
            {
                if (n.info > max.info) 
                    max = n;
                n = n.next;
            }
            return max;
        }
        public float tBC()
        {
            float sum = 0;
            int count = 0;
            Node p = head;

            while (p != null)
            {
                sum += p.info;
                count++;
                p = p.next;
            }
            return sum / count;
        }
    }

}
