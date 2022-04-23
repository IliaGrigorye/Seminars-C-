// Программа которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int k = 1;

if(n < 0)
    n = -n;

for (int i = 1; i <= n; i++)
{
    k = i * i * i;
    Console.Write(k + "; ");
}
