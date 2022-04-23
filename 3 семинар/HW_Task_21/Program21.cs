//Программа которая принимает на вход кординаты двух точек и находит растояние между ними в 3D пространстве.
//А(3,6,8);В(2,1,-7) -> 15.84

Console.Write("Введите первую кординату A (x1): ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую кординату A (y1): ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью кординату A (z1): ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую кординату B (x2): ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую кординату B (y2): ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью кординату B (z2): ");
int z2 = Convert.ToInt32(Console.ReadLine());

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;


double AB = Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)) + (Math.Pow(z, 2)));

Console.WriteLine("Кординаты точки А: (" + x1 + ", " + y1 + ", " + z1 + ")" );
Console.WriteLine("Кординаты точки B: (" + x2 + ", " + y2 + ", " + z2 + ")" );
Console.WriteLine("Расстояние между точками A и B: " + Math.Round(AB, 2));