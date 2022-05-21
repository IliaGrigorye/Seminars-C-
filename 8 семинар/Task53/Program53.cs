// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последниюю строку массива

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[lines, columns];

FillArray(array, 10, 99);
PrintArray(array);
Console.WriteLine("--------------");
ExchangeArray(array);
PrintArray(array);

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

//creates a two-dimensional array with the replacement of the first and last lines
void ExchangeArray(int[,] array)
{
    int line = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array [0, i] = array [line, i];
        array [line, i] = temp;
    }
}