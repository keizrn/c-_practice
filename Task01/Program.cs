Console.WriteLine("This program checks if the first number is the square of the second number. Input the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int number2 = int.Parse(Console.ReadLine());
int sqr = number2 * number2;
if (number1 == sqr)
{
Console.WriteLine($"The 1st number is a square of the 2nd number.");
}
else Console.WriteLine("No, the 1st number is NOT the square of the 2nd.");