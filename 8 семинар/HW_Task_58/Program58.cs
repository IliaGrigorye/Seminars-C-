// Программа которая будет находить произведение двух матриц.

const int lines = 4;
const int columns = 4;

int[,] firstArray = new int[lines, columns];
int[,] secondArray = new int[lines, columns];

FillFirstArray(firstArray, 2, 9);
PrintFirstArray(firstArray);
Console.WriteLine("--------------");
FillSecondArray(secondArray, 2, 9);
PrintSecondArray(secondArray);
Console.WriteLine("--------------");
ProductsArrays(firstArray, secondArray);

//fill first matrices with random numbers from min to max
void FillFirstArray(int[,] arr1, int min, int max)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr1.GetLength(1); j++)
            arr1[i, j] = new Random().Next(min, max);
}

//print first matrices to console
void PrintFirstArray(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
            Console.Write(arr1[i, j] + " ");
        Console.WriteLine();
    }
}

//fill second matrices with random numbers from min to max
void FillSecondArray(int[,] arr2, int min, int max)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(1); j++)
            arr2[i, j] = new Random().Next(min, max);
}

//print second matrices to console
void PrintSecondArray(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
            Console.Write(arr2[i, j] + " ");
        Console.WriteLine();
    }
}

//the product of two matrices
void ProductsArrays(int[,] arr1, int[,] arr2)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
            Console.Write((arr1[i, j] * arr2[i, j]) + " ");
        Console.WriteLine();
    }
}
