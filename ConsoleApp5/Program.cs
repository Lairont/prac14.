using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        /// <summary>
        /// Задача 5. В массиве хранятся сведения об оценках 25 учеников по химии. Определить количество неуспевающих по химии учеников.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int size = Size();
            int[] array = Inp(size);
            Out(array);
            Console.WriteLine($"\nНеуспевающие:");
            Unspecified(array);
            Console.ReadLine();
        }
        static int Size()
        {
            int[] array = new int[25];
            return 25;
        }
        static int[] Inp(int size)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 6);
            }
            return array;
        }

        static int Unspecified(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]<=3)
                {
                    Console.WriteLine($"Ученик[{i}]= {array[i]}");
                    count++;
                }    
            }
            return count;

        }
        static void Out(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Ученик[{i}]= {array[i]}");
            }
        }
    }
}
