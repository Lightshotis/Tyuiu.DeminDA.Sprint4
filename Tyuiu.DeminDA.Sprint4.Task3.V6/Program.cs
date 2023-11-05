using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DeminDA.Sprint4.Task3.V6.Lib;

namespace Tyuiu.DeminDA.Sprint4.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { 8, 8, 3, 4, 5 },

                { 8, 6, 6, 4, 6 },

                { 3, 6, 5, 3, 4 },

                { 5, 6, 3, 7, 5 },

                { 7, 8, 5, 6, 6 }
            };

            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;

            Console.Title = "Спринт #4 | Выполнил: Дёмин Д.А. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Дёмин Денис Александрович | ИИПБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9  подсчитать сумму         *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
