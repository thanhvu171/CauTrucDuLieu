using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
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
        public void themDau(int x)
        {
            Node p = new Node(x);
            p.next = head;
            head = p;
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
        public void inDanhSach()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write($"{p.info} ");
                p = p.next;
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
        public void xoaCuoi()
        {
            if (head != null)
            {
                Node p = head;
                Node q = null;
                while (p.next != null)
                {
                    q = p;
                    p = p.next;
                }
                q.next = null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LienKetDon A = new LienKetDon();
            Console.WriteLine("Danh sach lien ket don: ");
            NhapDanhSach(A);
            A.inDanhSach();

            Console.WriteLine("\nDanh sach xoa dau: ");
            A.xoaDau();
            A.inDanhSach();

            Console.WriteLine("\nDanh sach xoa cuoi: ");
            A.xoaCuoi();
            A.inDanhSach();

            Console.ReadKey();
        }
        static void NhapDanhSach(LienKetDon A)
        {
            string chon = "y";
            int x;
            while (chon != "n")
            {
                Console.Write("Nhap gia tri nut: ");
                x = int.Parse(Console.ReadLine());
                A.themDau(x);
                Console.Write("Tiep tuc:(y/n)? ");
                chon = Console.ReadLine();
            }
        }
    }
}
