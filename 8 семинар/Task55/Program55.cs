// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

if(lines != columns)
    Console.WriteLine("Замена не возможна, введите одинаковые числа");
    Environment.Exit(0);

int[,] array = new int[lines, columns];

FillArray(array, 10, 99);
PrintArray(array);
Console.WriteLine("--------------");
ReplacingRowsWithColumns(array);

//fill array with random numbers from min to max
void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max);
}

//print array to console
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void ReplacingRowsWithColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[j, i] + " ");
        Console.WriteLine();
    }
}
