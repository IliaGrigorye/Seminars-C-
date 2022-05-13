// Программа находящая среднее арифметическое элементов в каждом столбце в двумерном массиве.

const int lines = 6;
const int columns = 6;

int[,] array = new int[lines, columns];

FillArray(array, 1, 100);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));

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
            Console.Write(array[i, j] + "; ");
        Console.WriteLine();
    }
}


string ArithmeticMean(int[,] array)
{
    string result = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count++;
        }    
        mean = (double) sum / count;
        result += Math.Round(mean, 1).ToString() + "; ";
    }
    return result;    
}