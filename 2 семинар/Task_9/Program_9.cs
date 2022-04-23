// Для случайного числа в диапозоне 10-99 вывести наибольший ее цифру

int n = new Random().Next(10, 100);

int digit1 = n % 10;
int digit2 = n / 10;

if(digit1 > digit2)
    Console.WriteLine("Для чила " + n + " наибольшая цифра " + digit1);
else
    Console.WriteLine("Для чила " + n + " наибольшая цифра " + digit2);