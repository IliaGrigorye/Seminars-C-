// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диогонали

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array, 1, 100);

PrintArray(array);

Console.WriteLine();

SumDiagonalArray(array, 0);

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

//sum of the main diagonal of the array and print
void SumDiagonalArray(int[,] array, int sum)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j)
                sum += array[i, j];
    Console.WriteLine($"Сумма элементов на главной диагонали: {sum}");
}