using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /// <summary>
        /// Задача 3. Заполнить одномерный массив с клавиатуры и вывести элементы массива на экран в обратном порядке.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int size = Size();
            int[] array = Inp(size);
            Reverse(array);
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
            for (int i = 0; i < size; i++)
            {
                Console.Write($"array[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void Reverse(int[] array)
        {
            Array.Reverse(array);
        }
        static void Out(int[] array)
        {
            foreach(int rev in array )
            {
                Console.WriteLine(rev);
            }

        }
    }
}
