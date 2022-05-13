// Программа для нахождения точки пересечения двух прямых

Console.Write("Введите первое число для первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для первой прямой: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число для второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для второй прямой: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

if((b1 == b2) && (k1 == k2))
{
    Console.WriteLine("Две прямые совпадают.");
    Environment.Exit(0);
}
    
if((x == 0) || (y == 0))
{
    Console.WriteLine("Две прямые не пересекаются.");
    Environment.Exit(0);
}

else
    Console.WriteLine($"Точка пересечения ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
