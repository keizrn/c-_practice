// Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
            Console.Write($"{array[i2, j2]} ");
        }
        Console.WriteLine();
    }
}

int[,] Square3(int[,] arraysq)
{
    for (int i3 = 0; i3 < arraysq.GetLength(0); i3++)
    {
        if (i3 % 2 == 0)
        {
            for (int j3 = 0; j3 < arraysq.GetLength(1); j3++)
            {
                if (j3 % 2 == 0) arraysq[i3,j3] = arraysq[i3,j3] * arraysq[i3,j3];
            }
        }
    }
    return arraysq;
}

Console.WriteLine("Input array dimensions..");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
int[,] array3 = Square3(myArray);
Console.WriteLine();
PrintArray(myArray);
