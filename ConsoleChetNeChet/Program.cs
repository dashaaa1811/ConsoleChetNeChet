using System;


//Задача 1: Определение четности чисел в массиве
//Условие: Необходимо обработать массив чисел и для каждого элемента массива вывести, является ли число четным или нечетным, используя конструкцию switch.

//Входные данные: Массив целых чисел, например: { 1, 2, 3, 4, 5}.

//Выходные данные: Для каждого элемента массива выводится строка:

//"Четное" или "Нечетное" в зависимости от значения числа.

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
