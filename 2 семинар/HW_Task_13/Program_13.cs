//13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((-99 <= number) && (number <= 99))
{
    Console.WriteLine("у числа " + number + " нет третьей цифры");
    Environment.Exit(0);
}

while ((-999 > number) || (number > 999))
{
    number = number / 10; 
}

Console.WriteLine("третья цифра " + number % 10);

