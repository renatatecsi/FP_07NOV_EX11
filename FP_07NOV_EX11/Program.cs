using System;
namespace continue2
{
    class Progarm
    {
        static void Main(string[] args)
        {
            int n, x;
            Console.WriteLine("Dati un numar:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("x =");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; ++i)
            {
                if (i % x == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}