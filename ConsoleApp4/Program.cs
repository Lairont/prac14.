using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        /// <summary>
        /// Задача 4. Заполнить одномерный массив случайным образом от -5 до 5 целыми числами. Увеличить все элементы в два раза.
        /// Вывести новые значения массива с использованием цикла foreach.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int size = Size();
            int[] array = Inp(size);
            Double(array);
            Out(array);
            Console.ReadLine();
        }
        static int Size()
        {
            Console.Write("Введите размер массива: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка");
            }
            return size;
        }
        static int[] Inp(int size)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-5, 6);

            }
            return array;
        }
        static void Double(int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
        }
        static void Out(int[] array)
        {
            foreach(int omas in array)
            {
                Console.WriteLine(omas);
            }
        }
    }
}
