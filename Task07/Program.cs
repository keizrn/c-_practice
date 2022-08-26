// A program to show the last digit of 3-digit input number.
Console.WriteLine("This program gives you the last digit of the 3-digits number.");
Console.WriteLine("Please input your number: ");
int number1 = int.Parse(Console.ReadLine());
int ans = number1 % 10;
Console.WriteLine($"{ans}");

//string string2 = number1.ToString().Remove(0,2);
//Console.WriteLine($"{string2}");