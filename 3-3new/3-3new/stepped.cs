using _3_3new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3new
{
    internal class SteppedArr : IPrinter, IBase, IStChange
    {
        private Random rnd = new Random();
        private int[][] array;
        public SteppedArr()
        {
            Initializ();
        }

        public void Initializ()
        {
            Console.WriteLine("Ступенчатые  массивы");
            Console.WriteLine("Введите количество строк");
            int colN = int.Parse(Console.ReadLine());
            array = new int[colN][];
            for (int i = 0; i < colN; i++)
            {
                Console.WriteLine("Сколько элементов в строке " + (i + 1) + "?");
                int newlength = int.Parse(Console.ReadLine());
                array[i] = new int[newlength];
            }
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

        public void countAverage()
        {
            Console.WriteLine("Среднее значение в ступенчатом массиве:");
            int m = 0;
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    m += array[i][j];
                }
                num += array[i].Length;
            }
            Console.WriteLine(m / num);
        }
        public void Print()
        {
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        /*public override void Output()
        {
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }*/

        public void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элементы строки " + (i + 1));
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }

            }
        }

        public void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rnd.Next(-100, 100);
                }
            }
        }

        public void Change()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                        if (array[i][j] % 2 == 0)
                        {
                            array[i][j] = i * j;
                            array[i][j] = i * j;
                        }
                }
            }
        }
    }
}
