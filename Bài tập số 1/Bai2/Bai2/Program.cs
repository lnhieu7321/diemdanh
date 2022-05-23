using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

      


            Console.Write("Nhap mot so bat ky (0-9): ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.Write("So khong\n");
            }
            else if (a == 1)
            {
                Console.Write("So mot\n");
            }
            else if (a == 2)
            {
                Console.Write("So hai\n");
            }
            else if (a == 3)
            {
                Console.Write("So ba\n");
            }
            else if (a == 4)
            {
                Console.Write("So bon\n");
            }
            else if (a == 5)
            {
                Console.Write("So nam\n");
            }
            else if (a == 6)
            {
                Console.Write("So sau\n");
            }
            else if (a == 7)
            {
                Console.Write("So bay\n");
            }
            else if (a == 8)
            {
                Console.Write("So tam\n");
            }
            else if (a == 9)
            {
                Console.Write("So chin\n");
            }
            else
            {
                Console.Write("Ban da nhap so khong hop le. Xin nhap lai!!!\n");
            }
           

            Console.ReadKey();
        }
    }
}
