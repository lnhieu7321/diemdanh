using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("nhap do dai canh thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap do dai cannh thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap do dai canh thu ba: ");
            c = Convert.ToInt32(Console.ReadLine());
            if ((c * c == a * a + b * b) || (b * b == c * c + a * a) || (a * a== b * b + c * c))
            {
                Console.Write("Day la tam giac vuong");
            }
            else
            {
                Console.Write("Day khong phai tam giac vuong");
            }

            Console.ReadKey();
        }
    }
}
