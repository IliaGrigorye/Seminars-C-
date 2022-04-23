// Программа которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11

Console.Write("Введите число: ");
int n;

while(!int.TryParse(Console.ReadLine(), out n))
{
    Console.Write("Ошибка, введите число: ");
}
Console.Write($"Сумма цифр в числе {n} = ");
if (n < 0)
{
    n = -n;
}

int sum = 0; //сумма чисел
int k = 0;
for (int i = 0; i < n * 10; i++)
{
    k = n % 10 ;
    sum = sum + k;
    n = n / 10;
}

Console.WriteLine(sum);

