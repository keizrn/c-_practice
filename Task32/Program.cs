// Напишите программу замена элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.
int[] GetArray1(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ChangeSign2(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = -array2[i];
    }
    return array2;
}
int[] myArray1 = GetArray1(10,-100,100);
Console.WriteLine(String.Join("|",myArray1));
Console.WriteLine(String.Join(" ",ChangeSign2(myArray1)));