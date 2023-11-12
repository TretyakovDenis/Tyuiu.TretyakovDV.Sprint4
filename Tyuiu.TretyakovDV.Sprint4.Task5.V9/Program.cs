using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TretyakovDV.Sprint4.Task5.V9.Lib;

namespace Tyuiu.TretyakovDV.Sprint4.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Третьяков Д.В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Третьяков Денис Викторович | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 4. Найти количество          *");
            Console.WriteLine("* положительных элементов.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество строк массива");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива");
            int colums = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 4);
                }
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(matrix);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();


        }
    }
}