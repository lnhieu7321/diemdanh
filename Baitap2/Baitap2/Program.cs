using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Program
    {
        public class Animal
        {

            public void Eat()
            {
                Console.WriteLine("ăn. . .");
            }
            public void makeSound()
            {
                Console.WriteLine("phát ra tiếng. . .");
            }
        }
        class Cat : Animal
        {
            public void Run()
            {
                Console.WriteLine("Mèo đang chạy. . .");
            }
            Animal animal = new Animal();

        }
        class Bird : Animal
        {
            public void Fly()
            {
                Console.WriteLine("Chim đang bay. . .");
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cat cat = new Cat();
            cat.Run();
            cat.Eat();
            Bird bird = new Bird();
            bird.Fly();
            bird.makeSound();
            Console.ReadKey();
        }
    }
}