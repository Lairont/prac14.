using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// Задача 1. Массив предназначен для хранения значений ростов двенадцати человек.
        /// С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
        /// Вывести значения элементов с использованием цикла for. Найти средний рост.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int size = Size();
            int[] array = Inp(size);
            Out(array);
            Console.ReadLine();
        }
        static int Size()
        {
            int[] array = new int[12];
            return 12;
        }
        static int[] Inp(int size)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(163, 191);
   
            }
            return array;
        }
        static void Out(int[]array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine($"array[{i}]= {array[i]}");
            }
            Console.WriteLine(Average(array));
        }
        static double Average(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
    }
}
