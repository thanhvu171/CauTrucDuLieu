using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03_DSLKD
{
    class Node
    {
        private Node _next;
        private int _info;

        public Node(int x)
        {
            _info = x;
            _next = null;
        }
        public int info
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
        public void themCuoi(int x)
        {
            Node p = new Node(x);
            if (head == null)
                head = p;
            else
            {
                Node q = head;
                while (q.next != null)
                {
                    q = q.next;
                }
                q.next = p;
            }
        }
        public void xoaDau()
        {
            if (head != null)
            {
                Node p = head;
                head = head.next;
                p.next = null;
            }
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
        public void xoaViTriX(int x)
        {
            if (head != null)
            {
                Node p = head;
                Node q = null;

                while (p != null && p.info != x)
                {
                    q = p;
                    p = p.next;
                }
                if (p != null)
                {
                    if (p == head)
                        xoaDau();
                    else
                    {
                        q.next = p.next;
                        p.next = null;
                    }
                }
            }
        }
    }
}
