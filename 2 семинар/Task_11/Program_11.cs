//Программа которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int n = new Random().Next(100, 1000);

int digit1 = n % 10;
int digit2 = n / 100;
int answer = digit2 * 10 + digit1;

Console.WriteLine("Для числа: " + n);
Console.WriteLine("Новое число: " + answer);