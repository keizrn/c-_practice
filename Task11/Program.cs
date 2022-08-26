// Random 3-digit number, then middle digit is removed

int number = new Random().Next(100,1000);

int ones = number % 10;
int hundreds = number /100;

int num2 = hundreds * 10 + ones;
Console.WriteLine($"From random number {number} you get {num2}");