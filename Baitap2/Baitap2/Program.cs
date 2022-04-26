using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Program
    {
        public class Animal_122
        {

            public void Eat_122()
            {
                Console.WriteLine("ăn. . .");
            }
            public void makeSound_122()
            {
                Console.WriteLine("phát ra tiếng. . .");
            }
        }
        class Cat_122 : Animal_122
        {
            public void Run_122()
            {
                Console.WriteLine("Mèo đang chạy. . .");
            }
            Animal_122 animal = new Animal_122();

        }
        class Bird_122 : Animal_122
        {
            public void Fly_122()
            {
                Console.WriteLine("Chim đang bay. . .");
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cat_122 cat = new Cat_122();
            cat.Run_122();
            cat.Eat_122();
            Bird_122 bird = new Bird_122();
            bird.Fly_122();
            bird.makeSound_122();
            Console.ReadKey();
        }
    }
}