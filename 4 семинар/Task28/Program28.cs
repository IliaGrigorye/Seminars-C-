// Программа которая принимает на вход число (N) и выдает произведение чисел от 1 до А

int n;

Console.Write("Please, enter positive integer number: ");

while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Wrong inpunt, try again");
    Console.Write("Please, enter positive integer number: ");
}

int sum = 1;
for (int i = 1; i <= n; i++)
{
    sum *= i;
}
Console.WriteLine($"multiplication of all numbers from 1 to {n}: {sum}");