// 
Console.WriteLine("Input any number more than 1..");
int num = int.Parse(Console.ReadLine());
int counter = 1;
if (num < 1)
{
    Console.WriteLine($"Your number {num} is incorrect.");
}
else  
// {
//     int counter = 1;
//     while (counter <= num)
//         {
//             Console.Write($"{counter * counter} ");
//             counter++;
//         }
// }
// bool check1 = int.TryParse(string1,out int number);
{
    Console.WriteLine();
    for (int i=1; i<=num; i++)
    {
        Console.Write($"{i*i}, ");
    }
}
