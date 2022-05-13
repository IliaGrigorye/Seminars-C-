// Задайте двумерный массив размером mxn, заполненый случайными числами

const int m = 4;
const int n = 3;

int[,] arr = new int[m, n];

FillArray(arr, -100, 100);

PrintArray(arr);

//fill array with random numbers from min to max
void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max);
}

//print array to console
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            Console.WriteLine($"array[{i},{j}] ={array[i, j]}");
}