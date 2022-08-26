// Random number in [10,99] then compare 2 digits and show maximal

int number = new Random().Next(10,100); //[a,b) - левая граница входит, правая не входит
// создаю новое случайное число в следующем интервале от 1 до 100

Console.WriteLine(number);

int ones = number % 10;
int tens = number / 10;

int max = ones;
if (tens>ones)
{
    max = tens;
}
Console.WriteLine(max);