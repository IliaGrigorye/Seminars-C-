// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты.

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array, 2, 15);
PrintArray(array);

Console.WriteLine();

SquareArray(array);
PrintSqaringArray(array);

//fill array with random numbers from min to max
void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max);
}

//print fill array to console
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

//squaring even numbers of arrays
void SquareArray(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i+=2)
        for (int j = 2; j < array.GetLength(1); j+=2)
            array[i, j] = array[i, j] * array[i, j];
}

//print squaring even numbers of array to console
void PrintSqaringArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
