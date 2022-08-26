// Checks if one of the numbers is the square of another
Console.WriteLine("Please input first number.. ");
string str = Console.ReadLine();
if (str == "")
{
    Console.WriteLine("Empty number");
}
else 
{int num1 = int.Parse(str);
Console.WriteLine("Please input second number.. ");
string str2 = Console.ReadLine();
if (str2 == "")
{
    Console.WriteLine("Empty number");
}
else 
{
int num2 = int.Parse(str2);

int sqr1 = num1 * num1;
int sqr2 = num2 * num2;

if ((sqr1 == num2) || (sqr2 == num1))
{
    Console.WriteLine($"Yes, one of your numbers is a square of another: {num1}, {num2}");
}
else Console.WriteLine($"No, none of your numbers is a square of another: {num1}, {num2}");}}