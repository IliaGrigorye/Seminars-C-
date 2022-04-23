Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int square = numberOne * numberOne;
if (square == numberTwo)
{
    Console.Write("Да");
    }
else
{
    Console.Write("Нет");
    }
