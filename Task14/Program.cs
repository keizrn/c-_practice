// checks if number can be divided by 7 and 23 with 0 remainder
Console.WriteLine("Please input number... ");
int number = int.Parse(Console.ReadLine());

if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine($"Your number ({number}) can be fully divided by 7 & by 23.");
}
else Console.WriteLine($"Your number({number}) can not be divided by 7 & 23 without a remainder");