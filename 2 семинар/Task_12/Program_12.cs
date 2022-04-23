//Программа которая принимает на вход два числа и выводит, 
//являеться ли первое число кратным второму. 
//Если первое число не кратно второму, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int digit1 = numberOne % numberTwo;

if (digit1 == 0)
    Console.WriteLine("Число " + numberOne + " кратно " + numberTwo);

else
    Console.WriteLine("Число " + numberOne + " Не кратно " + numberTwo + " Остаток " + digit1);
