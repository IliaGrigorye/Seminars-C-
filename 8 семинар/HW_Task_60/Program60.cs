// трёхмерный массив из неповторяющихся двузначных чисел. 
// Числа выбираются случайно, при этом проверяется, что такого числа еще не было. 
// Программа которая будет построчно выводить массив, добавляя индексы каждого элемента.

const int m = 3;
const int n = 3;
const int c = 3;

int[,,] array = new int[m, n, c];

FillArray(array, 10, 99);

PrintArray(array);

//fill array with random numbers from min to max
void FillArray(int[,,] arr, int min, int max)
{
    int sensor = 0;
    int randomNum = 0;
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                while(sensor == 0)
                {
                    randomNum = rand.Next(min, max);
                    sensor = CheckNumber(arr, randomNum);
                }
                arr[i, j, k] = rand.Next(min, max);
                sensor = 0;
            }
        }
    }
}       

//print array to console
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.WriteLine($"array[{i},{j},{k}] ={arr[i, j, k]}");
}

int CheckNumber(int[,,] arr, int randomNum)
{
    foreach (int item in arr)
        if (item == randomNum)
            return 0;
    return 1;
}