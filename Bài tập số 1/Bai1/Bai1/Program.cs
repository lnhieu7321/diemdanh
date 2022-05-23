using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Nhap mot so bat ky: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Day la so nguyen am");
            }
            else
            {
                Console.WriteLine("Day la so nguyen duong");
            }
            Console.ReadKey();
        }

    }
}


