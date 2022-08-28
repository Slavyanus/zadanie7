// Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.

using System;
using System.Linq;
using System.Collections.Generic;
 
class Program
{
    private static Random rnd = new Random();
 
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int m = n;
        Queue<int> que = new Queue<int>(Enumerable.Range(0, n * m).OrderBy(_ => rnd.NextDouble()));
        int[,] arr = new int[n, m];
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                if (j != 0) Console.Write('\t');
                Console.Write(arr[i, j] = que.Dequeue());
            }
            Console.WriteLine();
        }
    }
}
