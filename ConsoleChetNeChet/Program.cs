using System;

namespace ConsoleChetNeChet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, };
            foreach (var arr in array)
            {
                switch (arr % 2)
                {
                    case 0:
                        Console.WriteLine($"{arr}-четное");
                        break;
                    case 1:
                        Console.WriteLine($"{arr}-нечетное");
                        break;
                }
            }
        }

    }
}
