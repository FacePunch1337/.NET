using System;

namespace ReverseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int value = Convert.ToInt32(Console.ReadLine());


            int part1 = value /= 1;
            part1 %= 10;

            int part2 = value /= 10;
            part2 %= 10;

            int part3 = value /= 10;


            Console.Write("Результат: ");
            Console.Write(part1);
            Console.Write(part2);
            Console.Write(part3);
            Console.Write('\n');



        }
    }
}