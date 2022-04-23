//15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число обозначающий день недели: ");
int numberDays = Convert.ToInt32(Console.ReadLine());
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

if ((numberDays > 7) || (numberDays < 1))
{
    Console.WriteLine("Ошибка, введите число от 1 до 7");
    Environment.Exit(0);
}
if (numberDays > 5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}

Console.WriteLine(numberDays + "-й день недели - это " + Days[numberDays - 1]);