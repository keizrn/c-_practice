// Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
int[] RandomArray2(int size2, int min2, int max2)
{
    int[] array2 = new int[size2];
    for (int k = 0; k < size2; k++)
    {
        array2[k] = new Random().Next(min2,max2);
    }
    return array2;
}

/*int[] ReverseArray1(int[] array1)
{
    int size1 = array1.Length;
    int[] result1 = new int[size1];
    for (int i=0; i < size1; i++)
    {
        result1[i] = array1[size1-1-i];
    }
    return result1;
}*/

void ReverseArray1(int[] array1)
{
    int size1 = array1.Length;
    int temp1 = 0;
    for (int i=0; i < size1/2; i++)
    {
        temp1 = array1[size1-1-i];
        array1[size1-1-i] = array1[i];
        array1[i] = temp1;
    }
}


int[] array0 = RandomArray2(6, 0, 100);
Console.WriteLine(String.Join(" ",array0));
ReverseArray1(array0);
Console.WriteLine(String.Join(" ",array0));