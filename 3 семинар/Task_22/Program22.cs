// Программа которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.Write("Введите длину: ");
int n = Convert.ToInt32(Console.ReadLine());
int k = 1;

if(n < 0)
    n = -n;

for (int i = 1; i <= n; i++)
{
    if (i % 1 == 0)
        k = i * i;
    Console.Write(k + "; ");
}