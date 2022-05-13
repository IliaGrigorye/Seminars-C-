// программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

const int lines = 6;
const int columns = 6;

int[,] array = new int[lines, columns];

FillArray(array, 0, 100);
PrintArray(array);
CheckingAvailability(array, m, n);

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

//checking for the presence of an element in the array
void CheckingAvailability(int[,] array, int m, int n)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
        if(i == m)
            for (int j = 0; j < array.GetLength(1); j++)
                if(j == n)
                {
                    Console.WriteLine($"Число [{m}, {n}] = {array[m, n]}");
                    Environment.Exit(0);
                }
    Console.WriteLine($"Числа [{m}, {n}] нет в массиве");                
}

