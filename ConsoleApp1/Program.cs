using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    ///Заполнить одномерный массив с клавиатуры и вывести его.
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            int size = Size();
            int[] array = Inp(size);
            Out(array);
            Console.ReadLine();
        }
        /// <summary>
        /// метод ввова одномерного массива
        /// </summary>
        /// <returns>размер</returns>
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
        /// <summary>
        /// метот ввода значения массива
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        static int[] Inp(int size)
        {
            int[] array = new int[size];
            for(int i=0;i<size;i++)
            {
                Console.Write($"array[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        /// <summary>
        /// Метод вывода 
        /// </summary>
        /// <param name="array"></param>
        static void Out(int[]array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine($"array[{i}]= {array[i]}");
            }
        }
    }
}
