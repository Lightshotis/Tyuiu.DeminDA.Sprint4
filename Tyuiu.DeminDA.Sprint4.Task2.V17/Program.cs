using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DeminDA.Sprint4.Task2.V17.Lib;

namespace Tyuiu.DeminDA.Sprint4.Task2.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Дёмин Д.А. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Дёмин Денис Александрович | ИИПБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9  подсчитать сумму         *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            int len = 9;

            int[] numsArry = new int[len];

            for (int i = 0; i <= len -1; i++)
            {
                numsArry[i] = rnd.Next(3, 9);
            }

            Console.Write("Массив: ");
            for (int i = 0; i <= len-1; i++)
            {
                Console.Write(numsArry[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArry);

            Console.WriteLine("Произведение нечётных элементов = " + res);
            Console.ReadLine();


        }
    }
}
