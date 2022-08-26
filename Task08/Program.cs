// по номеру четверти разлет координат для x & y

Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine($"В четверти {num} x может быть в интервале [0, +inf), y может быть в интервале [0, +inf)");
}
else if (num == 2)
{
     Console.WriteLine($"В четверти {num} x может быть в интервале (-inf, 0], y может быть в интервале [0, +inf)");
}
else if (num == 3)
{
     Console.WriteLine($"В четверти {num} x может быть в интервале (-inf, 0], y может быть в интервале (-inf, 0]");
}
else if (num == 4)
{
     Console.WriteLine($"В четверти {num} x может быть в интервале [0, +inf), y может быть в интервале (-inf, 0]");
}
else Console.WriteLine("Введён некорректный номер четверти.");