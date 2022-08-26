// Checks if second number is divided by first with a zero remainder. 
//If not, program shows the remainder.

Console.WriteLine("Input first number.. ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number.. ");
int num2 = int.Parse(Console.ReadLine());

int rem = num2 % num1;
if (rem>0)
{
    Console.WriteLine($"Number {num2} can not be fully divided by {num1}, the remainder is {rem}.");
}
else Console.WriteLine($"Number {num2} is fully divided by {num1}.");