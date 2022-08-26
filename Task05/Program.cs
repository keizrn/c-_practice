// Writes line of numbers from (minus X) to (X)
Console.WriteLine("This program gives you a line of numbers from (minus X) to (X). Input non-negative number: ");
int number1 = int.Parse(Console.ReadLine());
int current = - number1;
while (current <= number1)
{
    Console.Write($"{current} ");
    current += 1;
    //current++;
    //current = current + 1;
}