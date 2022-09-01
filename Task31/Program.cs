// Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] GetArray1(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int[] PosNegSum2(int[] array2)
{
    int[] res2 = new int[2];
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] > 0)
        {
            res2[0] += array2[i];
        }
        else
        {
            res2[1] += array2[i];
        }
    }
    return res2;
}

void PostiveSum(int[] array)        //другой вариант через foreach
{
    int positiveSum = 0;

    foreach(int el in array)
    {
        positiveSum += el > 0 ? el : 0;
    }

    
    Console.WriteLine($"{positiveSum}");
}


int[] myArray1 = GetArray1(10,-100,100);
int[] resArray = PosNegSum2(myArray1);
Console.WriteLine(String.Join("|",myArray1));
Console.WriteLine(String.Join(" ",resArray));

int[] ProductionArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 != 0) size++;
    int[] result = new int[size];
    Console.WriteLine(String.Join(" ", array));
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[^(i + 1)];
        if (i * 2 + 1 == array.Length) result[i] = array[i];
        Console.WriteLine(String.Join(" ", result));
    }
    return result;
    
}

int[] ProductionArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 != 0) size++;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) result[size - 1] = array[array.Length / 2];
    return result;
    
}


bool FindNumber(int[] array, int num)
{
    foreach (int el in array)
    {
        if (el == num) return true;
    }
    return false;
}
if (FindNumber(newArray, number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");
