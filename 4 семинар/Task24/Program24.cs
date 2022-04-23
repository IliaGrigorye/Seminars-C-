//Программа которая принимает на вход число (А) и выдает сумму чисел от 1 до А

int n;

Console.Write("Please, enter positive integer number: ");

while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Wrong inpunt, try again");
    Console.Write("Please, enter positive integer number: ");
}

int sum = (n + 1) * n / 2;
//int sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    sum += i;
//}
Console.WriteLine("sum of all numbers from 1 to " + n + " equal " + sum);



