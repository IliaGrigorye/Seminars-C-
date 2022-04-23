//программа которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

if ((numberOne % 7 == 0) && (numberOne % 23 ==0))
    Console.WriteLine("Число " + numberOne + " кратно 7 и 23");
else
    Console.WriteLine("Число " + numberOne + " не кратно 7 и 23");

