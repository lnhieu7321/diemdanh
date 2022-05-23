using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Struct
{
    class Program
    {
        enum dienSinhVien
        {
            hoNgheo,
            hoCanNgheo,
            khaGia,
        }
        struct SinhVien
        {
            public int MaSV_122;
            public string HoTen_122;
            public double DiemToan_122;
            public double DiemLy_122;
            public double DiemVan_122;
            public int dienSinhVien_122;
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma SV: ");
            SV.MaSV_122 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen_122 = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan_122 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy_122 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan_122 = Double.Parse(Console.ReadLine());
            Console.Write(" Dien Sinh Vien: ");
            SV.dienSinhVien_122 = int.Parse(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSV_122);
            Console.WriteLine(" Ho ten: " + SV.HoTen_122);
            Console.WriteLine(" Diem toan: " + SV.DiemToan_122);
            Console.WriteLine(" Diem ly: " + SV.DiemLy_122);
            Console.WriteLine(" Diem van: " + SV.DiemVan_122);
            if (SV.dienSinhVien_122 == (int)dienSinhVien.hoNgheo)
            {
                Console.WriteLine(" Thuoc dien: Ho Ngheo");
            }
            else if (SV.dienSinhVien_122 == (int)dienSinhVien.hoCanNgheo)
            {
                Console.WriteLine(" Thuoc dien: Ho Can Ngheo");
            }
            else
            {
                Console.WriteLine(" Thuoc dien: Kha Gia");
            }
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan_122 + SV.DiemLy_122 + SV.DiemVan_122) / 3;
        }

        static void Main(string[] args)
        {


            int n_122;
            do
            {
                Console.Write("Nhap SL sinh vien: ");
                n_122 = int.Parse(Console.ReadLine());
            } while (n_122 <= 0);
            SinhVien[] sv122 = new SinhVien[n_122];
            for (int i = 0; i < n_122; i++)
            {
                Console.Write("Nhap vao SV[{0}]: \n", i + 1);
                NhapThongTinSinhVien(out sv122[i]);
            }

            Console.WriteLine("DANH SACH DUYEN SINH VIEN: ");
            int d = 0;
            foreach (SinhVien sv in sv122)
            {
                Console.WriteLine("\nSinh vien thu {0}: \n", d + 1);
                XuatThongTinSinhVien(sv);
                d++;
            }


            string searchSV_122;
            Console.Write("\nNhap vao ten sv can tim kiem: ");
            searchSV_122 = Console.ReadLine();
            foreach (SinhVien sv in sv122)
            {
                if (sv.HoTen_122 == searchSV_122)
                {
                    Console.WriteLine("Diem TB cua sinh vien {0} la: {1} ", searchSV_122, DiemTBSinhVien(sv));
                }
            }
            Console.ReadKey();
        }
    }
}