using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// Задача 2. Заполнить массив из восьми элементов следующими значениями с использованием явной инициализации:
        /// первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, восьмой —13.
        /// Найти максимальный и минимальный элементы массива.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] array = Inp();
            Out(array);
            Console.WriteLine($"Max= {Max(array)}");
            Console.WriteLine($"Min= {Min(array)}");
            Console.ReadLine();
        }
        static int[] Inp()
        {
            int[] array = new int[8] {37, 0, 50, 46, 34, 46, 0, 13};
            return array;
        }
        static void Out(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]= {array[i]}");
            }
            
          }
        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
