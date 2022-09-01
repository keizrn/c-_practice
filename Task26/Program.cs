// Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе.
int CountDigital1(int num1)
{
    int count1 = 0;
    while (num1/10 != 0)
    {
        count1++;
        num1 = num1/10;
    }
    count1++;
    return count1;
}

Console.WriteLine("Input any number..");
string temp0 = Console.ReadLine();
bool check0 = int.TryParse(temp0, out int num0);
if ((temp0 == "") || (check0 == false)) 
{
    Console.WriteLine("Your input is incorrect.");
}
else
{
    Console.WriteLine($"Number of digits is {CountDigital1(num0)}");
}