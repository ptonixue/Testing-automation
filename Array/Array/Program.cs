using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press \"Ctrl+C\" for exit");

            //По ТЗ известно, что массив будет двумерный
            int[,] array_1 = new int[2,2];
            int[,] array_2 = new int[2,2];

            //Заполнение матрицы
            Console.WriteLine("Введите элементы первого массива:");
            fillArray(array_1);

            Console.WriteLine("Введите элементы второго массива:");
            fillArray(array_2);

            //Сложение двух массивов
            int[,] array_sum = new int[2, 2];
            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_2.GetLength(1); j++)
                {
                    array_sum[i, j] = array_1[i, j] + array_2[i, j];
                }
            }

            //Вывод матрицы
            //Console.WriteLine("Массив №1:");
            //printArray(array_1);

            //Console.WriteLine("Массив №2:");
            //printArray(array_2);

            Console.WriteLine("Суммарный массив:");
            printArray(array_sum);

            Console.ReadLine();

        }

        //Метод вывода массива на экран
        static void printArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" array[" + i + "," + j + "]: " + array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //Метод ввода массива с клавиатуры
        static void fillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("array[" + i + "," + j + "]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine('\n');
        }

    }

}
