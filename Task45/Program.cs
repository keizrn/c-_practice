// Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.
int[] RandomArray2(int size2, int min2, int max2)
{
    int[] array2 = new int[size2];
    for (int k = 0; k < size2; k++)
    {
        array2[k] = new Random().Next(min2,max2);
    }
    return array2;
}

int[] CopyArray1(int[] array1)
{
    int[] result1 = new int[array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        result1[i] = array1[i]+1;
    }
    return result1;
}

int[] array0 = RandomArray2(6, 0, 100);
Console.WriteLine(String.Join(" ",array0));
Console.WriteLine(String.Join(" ",CopyArray1(array0)));