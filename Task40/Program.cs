// Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник со сторонами такой длины.
bool CheckTri1(double side1, double side2, double side3)
{
    bool check1 = false;
    if (side1 < (side2 + side3)) check1 = true;
    return check1;
}

Console.WriteLine("Input 3 sides..");
double sideA = double.Parse(Console.ReadLine());
double sideB = double.Parse(Console.ReadLine());
double sideC = double.Parse(Console.ReadLine());
if ((CheckTri1(sideA, sideB, sideC)) && (CheckTri1(sideB, sideC,sideA) 
    && (CheckTri1(sideC, sideA, sideB)))) Console.WriteLine("Triangle YES");
    else Console.WriteLine("Triangle NO");
