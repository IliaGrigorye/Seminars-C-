//Программа которая будет находить строку с наименьшей суммой элементов.

const int lines = 6;
const int columns = 4;

int[,] array = new int[lines, columns];

FillArray(array, 10, 99);
PrintArray(array);
Console.WriteLine("--------------");

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

//Search for a row with the minimum sum of elements
int MinimumSum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int index = 0;
    int n = array.GetLength(0) - 1;
    int m = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (i == 0)
            {
                sum += array[i, j];
                minSum += array[i, j];
            }
            else
                sum += array[i, j];   
        }
        if(sum < minSum)
        {
            minSum = sum;
            index = i + 1;
        }
        sum = 0;
    }
    return index;   
}

Console.WriteLine("Наименьшая сумма элеметов на " + MinimumSum(array) + " строке");