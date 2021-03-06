// Программа которая находит разницу между максимальным и минимальным значением элементов массива. Длина массива задается с терминала.
// [3 7 22 2 78] -> 76

//------------------------------------------------------------------------------------

// 1. Создать массив из n элементов
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// 2. Заполнить его случайными вещественными числами
FillArray(array, 1, 99);
// 3. Вывести массив
PrintArray(array);
// 4. Подсчет разницы и вывод
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
            Console.Write("[" + arr[i] + ", ");
        else if (i == array.Length - 1)
            Console.Write(arr[i] + "] -> ");
        else
            Console.Write(arr[i] + ", ");
}

// Найти разницу
void PrintQuan(int[] arr)

{
    int k = 0;
    int max = arr[0];
    int min = arr[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }

    }

    k = max - min;
    Console.Write($"разница {k}");
}
