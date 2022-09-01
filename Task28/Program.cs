// Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
int Mult1 (int num1)
{
    int multi1 = 1;
    for (int i = 1; i < num1+1; i++)
    {
        multi1 = multi1 * i;
    }
    return multi1;
}
Console.WriteLine("Input number..");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Multiplication from 1 to {num2} is equal to {Mult1(num2)}");