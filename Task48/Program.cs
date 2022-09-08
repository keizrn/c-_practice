﻿// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
//по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input array dimensions..");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
