// Программа принимает на вход пятизначное число и проверяет, являеться ли оно палиндромом.
//14212 -> нет; 23432 -> да.

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n > 99999) || (n < -99999))
{
    Console.WriteLine("Ошибка, введите пятизначное число");
    Environment.Exit(0);
}

int n1 = n % 10;
int n2 = n / 10 % 10;
int n3 = n / 1000 % 10;
int n4 = n / 10000;


if ((n1 == n4) && (n2 == n3))
{
    Console.WriteLine("Число " + n + " является палиндромом");
}
else
{
    Console.WriteLine("Число " + n + " не является палиндромом");
}