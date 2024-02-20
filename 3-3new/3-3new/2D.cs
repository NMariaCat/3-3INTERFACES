using _3_3new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3new
{
    internal class TwoDimentionArr : IPrinter, IBase, ISnakePrint
    {
        private Random rnd = new Random();
        private int[,] array;
        public TwoDimentionArr()
        {
            Initializ();
        }

        public void Initializ()
        {
            Console.WriteLine("Двумерные  массивы");
            Console.WriteLine("Введите количество элементов в столбце.");
            int colomnsN = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество элементов в строке.");
            int linesM = int.Parse(Console.ReadLine());
            array = new int[colomnsN, linesM];
            Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
            if (Console.ReadLine() == "+")
            {
                UserFill();
            }
            else
            {
                RandFill();
            }
        }

        public void UserFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Двумерный массив");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void countAverage()
        {
            Console.WriteLine("Среднее значение в двумерном массиве:");
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    k += array[i, j];
                }
            }
            Console.WriteLine(k / array.Length); ;
        }

        public void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
        }
        public void SnakePrint()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


