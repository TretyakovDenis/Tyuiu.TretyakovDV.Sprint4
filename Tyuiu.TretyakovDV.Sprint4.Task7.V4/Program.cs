using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TretyakovDV.Sprint4.Task7.V4.Lib;

namespace Tyuiu.TretyakovDV.Sprint4.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Третьяков Д.В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Третьяков Денис Викторович | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 382976421897. Преобразуйте ее в       *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            int n = 3;
            int m = 4;
            int[,] matrix = new int[n, m];
            string value = "382976421897";
            int index = 0;
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{value[index]} \t");
                        index++;
                    }
                    Console.WriteLine();
                }     
            }
            Console.WriteLine();
            int res = ds.Calculate(n, m, value);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();


        }
    }
}