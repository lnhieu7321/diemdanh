using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Nhap canh thu nhat: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap canh thu hai: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap canh thu ba: ");
            c = Convert.ToSingle(Console.ReadLine());
            if((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.Write("Day la tam giac\n");
            }
            else
            {
                Console.Write("khong phai la tam giac\n");
            }
            Console.ReadKey();
        }
    }
}
