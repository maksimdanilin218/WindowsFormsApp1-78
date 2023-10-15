using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(30);
            int count = 1;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("ИИ загадал число от 0 до 30.");
            Console.WriteLine("Попробуйте отгадать это число, у вас 5 попыток.");
            Console.WriteLine("Автор: Данилин Максим, 149 группа 3 курс.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Введите первое число:");
            int k = Convert.ToInt32(Console.ReadLine());

            while (count <= 5)
            {
                if (i == k)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Победа за тобой!");
                    Console.WriteLine("ИИ загадал число " + k + ". :) ");
                    Console.WriteLine("--------------------------------------------------");
                    break;
                }
                else
                {
                    count++;
                    if (count == 6)
                    {
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Победил ИИ! Это было число: " + i + ".");
                        Console.WriteLine("Увы, вы не отгадали загаданное число! :( ");
                        Console.WriteLine("--------------------------------------------------");
                        break;
                    }
                    Console.WriteLine("Нет, это не число " + k + "! Попытка № " + count + ":");
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
