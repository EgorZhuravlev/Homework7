﻿/* Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

double[,] array = GetMatrix(3,4);
Print2DArray(array);

double[,] GetMatrix(int rows, int columns)
{
    Random random = new Random();
    double[,] array = new double[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble() * 10, 1);;
        }

    }
    return array;
    
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}