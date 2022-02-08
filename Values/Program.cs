using System;

namespace Values
{
    internal class V
    {
        static void Main()
        {

            Console.Write("Введите А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------");

            for (int i = a; i <= b; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }



          
        }
    }
}
