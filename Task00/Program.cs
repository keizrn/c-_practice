// TEST
Console.WriteLine("Input any number..");
string text1 = Console.ReadLine();
bool check1 = int.TryParse(text1, out int num1);
Console.WriteLine(check1);