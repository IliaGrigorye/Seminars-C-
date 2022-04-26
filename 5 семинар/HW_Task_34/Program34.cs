//программа которая показывает количество чётных чисел в массиве. Длина массива задается с терминала.
//[345, 897, 568, 234] -> 2

//------------------------------------------------------------------------------------

// 1. Создать массив из n элементов
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// 2. Заполнить его случайными положительными трехзначными числами
FillArray(array, 100, 999);
// 3. Вывести массив
PrintArray(array);
// 4. Подсчет количества четных и вывод
PrintQuan(array);

//--------------------------------------------------------------------------------------

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
        if (i == 0)
            Console.Write("В массиве [" + arr[i] + ", ");
        else if (i == array.Length - 1)
            Console.Write(arr[i] + "] -> ");
        else
            Console.Write(arr[i] + ", ");
}

// Найти кол-во
void PrintQuan(int[] arr)

{
    int k = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (arr[i] % 2 == 0 )
        {
            k++;
        }
    }
    Console.Write($"{k} четных");
}
