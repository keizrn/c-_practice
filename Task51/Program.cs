// Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i1 = 0; i1 < m; i1++)
    {
        for (int j1 = 0; j1 < n; j1++)
        {
            result[i1, j1] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i2 = 0; i2 < array.GetLength(0); i2++)
    {
        for (int j2 = 0; j2 < array.GetLength(1); j2++)
        {
            Console.Write($"{array[i2, j2]}\t");
        }
        Console.WriteLine();
    }
}

int ArraySum3(int[,] array3)
{
    int sum3 = 0;
    int min3 = array3.GetLength(0);
    int col3 = array3.GetLength(1);
    if (min3 > col3) min3 = col3;
    for (int i3 = 0; i3 < min3; i3++)
        {
            sum3 = sum3 + array3[i3,i3];
        }
    return sum3;
}

Console.WriteLine("Input array dimensions..");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input min & max..");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"Sum of main diagonal is {ArraySum3(myArray)}");
