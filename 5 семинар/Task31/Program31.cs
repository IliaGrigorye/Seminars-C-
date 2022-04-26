// Массив из 12 элементов, заполненый числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// [2,9,-8,1,0,-7,-1,8,-3,-1,6] Сумма положительных 29, отрицательных -20

// 1. Создать массив из 12 элементов
int[] array = new int[12];
// 2. Заполнить его случайными числами от -9 до 9
FillArray(array, -9, 9);
// 3. Вывести массив
PrintArray(array);
// 4. Найти сумму всех отрицательных
int sumNegativ = sumN(array);
Console.WriteLine($"Сумма отрицательных элементов массива = {sumNegativ}");
// 5. Найти сумму всех положительных
int sumPositiv = sumP(array);
Console.WriteLine($"Сумма отрицательных элементов массива = {sumPositiv}");
// Заполнить массив
void FillArray(int[] arr, int minV, int maxV)
{
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
        arr[i] = rand.Next(minV, maxV);
}    
// Вывести массив
void PrintArray(int[] arr)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine($"arr[{i}] = {arr[i]}");
}
// Найти сумму отрицательных элементов
int sumN(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (arr[i] < 0)
            sum += arr[i];
    }

    return sum;
}
// Найти сумму положительных элементов
int sumP(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (arr[i] >= 0)
            sum += arr[i];
    }

    return sum;
}