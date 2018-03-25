using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк массива");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов массива");
            int m = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[n, m];
            Console.WriteLine("\nВведите первый массив");
            FillArr(n, m, arr1);
            int[,] arr2 = new int[n, m];
            Console.WriteLine("\nВведите второй массив");
            FillArr(n, m, arr2);
            int[,] arrSum = new int[n, m];
            ArrAddition(n, m, arr1, arr2, arrSum);
            Console.WriteLine("\nСумма массивов:");
            PrintArr(n, m, arrSum);
            Console.ReadKey();
        }

        private static void ArrAddition(int n, int m, int[,] arr1, int[,] arr2, int[,] arrSum)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrSum[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
        }

        private static void PrintArr(int n, int m, int[,] arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(String.Format("{0,3}", arr[i, j]));
                }
                Console.Write("\n");
            }
        }

        private static void FillArr(int n, int m, int[,] arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try
                    {
                        Console.Write("arr[" + i + "," + j + "]: ");
                        arr[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неверные данные!");
                        arr[i, j] = 0;
                    }
                }
            }

        }
    }
}
