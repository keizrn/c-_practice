// Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
int[] RandomArray1(int size1)
{
    int[] array1 = new int[size1];
    for (int i=0; i<array1.Length;i++)
    {
        array1[i] = new Random().Next(0,2);
    }
    return array1;
}

Console.WriteLine("Input array size");
int size0 = int.Parse(Console.ReadLine());
Console.Write("Array : ");
Console.Write(String.Join(" ",RandomArray1(size0)));
