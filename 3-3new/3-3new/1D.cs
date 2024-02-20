using _3_3new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3new
{
    internal class OneDimentionArr : IPrinter, IBase, IDeleteSame
    {
        private int[] array;
        private Random rnd = new Random();
        public OneDimentionArr()
        {
            Initializ();
        }

        public void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public void RandFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }

        public void Initializ()
        {
            Console.WriteLine("Одномерные  массивы");
            Console.WriteLine("Введите количество элементов.");
            int ElementsNumber = int.Parse(Console.ReadLine());
            array = new int[ElementsNumber];
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

        public void Print()
        {
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void countAverage()
        {
            Console.WriteLine("Среднее значение в одномерном массиве:");
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                k += array[i];
            }
            Console.WriteLine(k / array.Length); ;
        }

        public void Delete()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Check(array, array[i]) == true)
                {
                    for (int k = i; k < array.Length; k++)
                    {
                        array[k] = array[k - 1];
                    }
                }
            }
        }

        bool Check(int[] arr, int k)
        {
            foreach (int i in arr)
            {
                if (i == k) return true;
            }
            return false;
        }
    }

}


