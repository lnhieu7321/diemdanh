using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class Program
    {
            public virtual void xuat()
            {
                Console.Write("Hình Gì");
            }

            class tamgiac : Program
        {
                public override void xuat()
                {
                    Console.Write("Hình Tam Giác");
                }
            }
            class tugiac : Program
        {
                public override void xuat()
                {
                    Console.Write("Hình Tứ Giác");
                }
            }
            class hinhbinhhanh : Program
        {
                public override void xuat()
                {
                    Console.Write("Hình Bình Hành");
                }
            }
            class hinhchunhat : Program
        {
                public override void xuat()
                {
                    Console.Write("Hình Chữ nhật");
                }
            }
            class vuong : Program
        {
                public override void xuat()
                {
                    Console.Write("Hình vuông");
                }
            }
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Chọn hình");
                switch (Console.ReadLine())
                {
                    case "Hinh vuong":
                        Program hvuong = new vuong();
                        hvuong.xuat();
                        break;

                    case "Hinh tam giac":
                        Program tg = new tamgiac();
                        tg.xuat();
                        break;
                    case "Hinh chu nhat":
                        Program cn = new hinhchunhat();
                        cn.xuat();
                        break;
                    case "Hinh binh hanh":
                        Program hbh = new hinhbinhhanh();
                        hbh.xuat();
                        break;
                    case "Hinh tu giac":

                    Program tug = new tugiac();
                        tug.xuat();
                        break;
                    default:
                        Console.WriteLine("Chọn hình");
                        break;
                }

                Console.ReadKey();
            }
        }
}
