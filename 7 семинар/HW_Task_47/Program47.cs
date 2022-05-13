//Массив размером m×n, заполненный случайными вещественными числами.

const int line = 5;
const int column = 6;

double[,] array = new double[line, column];

FillArray(array);
PrintArray(array);

//fill array with random real numbers
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().NextDouble();
}

//print array to console
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j],1) + "; ");
        Console.WriteLine();
    }
}
