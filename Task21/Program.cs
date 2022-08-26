// Длина отрезка по координатам его точек

Console.WriteLine("Input coordinate x1..");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input coordinate y1..");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input coordinate x2..");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Input coordinate y2..");
int y2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x1 - x2),2)+Math.Pow((y1 - y2),2));
Console.WriteLine($"{d:f2}");