// Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А.
int NumSum2 (int num2)
{
    int sum2 = 0;
    for (int i = 1; i <= num2; i++)
    {
        sum2 += i;
    }
    return sum2;
}

Console.WriteLine("Input non-negative number..");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine($"The sum is {NumSum2(num1)}");
