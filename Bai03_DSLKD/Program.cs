using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03_DSLKD
{
    class Program
    {
        static void Main(string[] args)
        {
            LienKetDon C = new LienKetDon();
            Console.WriteLine("Nhap danh sach lien ket don: ");
            NhapDanhSach(C);
            C.inDanhSach();

            Console.WriteLine("\nXoa nut vi tri x: ");
            int x = int.Parse(Console.ReadLine());
            C.xoaViTriX(x);
            Console.WriteLine("Danh sach sau khi xoa x: ");
            C.inDanhSach();

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
                A.themCuoi(x);
                Console.Write("Tiep tuc:(y/n)? ");
                chon = Console.ReadLine();
            }
        }

    }
}
