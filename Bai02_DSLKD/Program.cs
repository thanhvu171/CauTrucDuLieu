using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_DSLKD
{
    class Program
    {
        static void Main(string[] args)
        {
            LienKetDon B = new LienKetDon();
            Console.WriteLine("Nhap danh sach lien ket don: ");
            NhapDanhSach(B);
            B.inDanhSach();

            Console.WriteLine($"\nNut co gia tri lon nhat trong lien ket: {B.timNutCoGTLN().info}");
            Console.WriteLine($"\nTrung binh chung cua cac nut trong lien ket: {B.tBC()}");

            Console.ReadKey();
        }
        static void NhapDanhSach(LienKetDon B)
        {
            string chon = "y";
            float x;
            while (chon != "n")
            {
                Console.Write("Nhap gia tri nut: ");
                x = float.Parse(Console.ReadLine());
                B.themDau(x);
                Console.Write("Tiep tuc:(y/n)? ");
                chon = Console.ReadLine();
            }
        }

    }
}
