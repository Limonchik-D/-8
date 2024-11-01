using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. вывести в столбик 10 раз слово "Привет";
            //Console.WriteLine("Сколько раз вывести в столбик слово - Привет");            //int number = int.Parse(Console.ReadLine());
            /*int a = 0;            int b = 10;
            while(b >= a)
            {                Console.WriteLine("Привет");
                a++;            }
            Console.ReadLine();*/
            //2.вывести в столбик первые 10 натуральных чисел;
            /*
            int b = 0;
            do
            {
                Console.WriteLine(b++);
            }
            while (b <= 10);
            Console.ReadKey(); */
            //3. вывести в столбик первые 5 натуральных чисел в обратном порядке;
            /*
             for (int c = 5; c >= 1; c--)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey(); */


           //Задача 1. Заполнить одномерный массив из 8 целых чисел с клавиатуры и вывести его на экран.
           /*
           int[] omas = new int[8]; Console.WriteLine("Заполнение одномерного массива");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"omas [{i}]= "); omas[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ввывод одномерного масива");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"omas [{i}] = {omas[i]}");
            }
            Console.ReadKey(); */
            //Задача 2. Составьте программу ввода (без клавиатуры) и вывода массива: 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3.            /*int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };
            /*Console.WriteLine("Заполнение одномерного массива");
            for (int i = 0; i < 8; i++)            {
                Console.Write($"omas [{i}]= ");                omas[i] = int.Parse(Console.ReadLine());
            }*/
            /*Console.WriteLine("Ввывод одномерного масива");            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas [{i}] = {omas[i]}");            }
            Console.ReadKey();*/
            //Задача 3. Массив предназначен для хранения значений ростов двенадцати человек. С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
            /*int[] omas = new int[12];
            Random rnd = new Random(); for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rnd.Next(163, 190);
            }
            foreach (var element in omas)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey(); */
            //Найти среднюю температуру воздуха за октябрь месяца
            int[] omas = new int[31];
            Random rnd = new Random(); for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rnd.Next(0, 31);
            }
            foreach (var element in omas)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
