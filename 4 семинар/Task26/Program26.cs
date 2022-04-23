// Программа которая принимает на вход число и выдает количество цифр в числе
//456 -> 3

Console.Write("Введите число: ");
int n; // = Convert.ToInt32(Console.ReadLine());

while(!int.TryParse(Console.ReadLine(), out n))
{
    Console.Write("Ошибка, введите число: ");
}

Console.Write($"Число {n} ");
if (n < 0)
{
    n = -n;
}
int quan = 0; //количество чисел
for (int i = 0; i < n * 10; i++)
{
    n = n / 10 ;
    quan++;
}

Console.WriteLine($"состоит из {quan} чисел");
