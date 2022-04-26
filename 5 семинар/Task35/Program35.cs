// задайте одномерный массив из 123 случайных не отрицательных чисел. Найти кол-во двузначных чисел
// [4,12,5,16,7]->2
// ---------------------------------------------------------

// 1. Создать массив из 123 элементов
int[] array = new int[123];
// 2. Заполнить его случайными числами положительными числами
FillArray(array, 0, 999);
// 3. Вывести массив
PrintArray(array);
// 4. Найти кол-во двухзначных и вывести
PrintQuan(array);

//-----------------------------------------------------------------------

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
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if ((arr[i] < 99) && (arr[i] > 10))
        {
            n++;
        }
    }
    Console.Write($"{n} двухзначных");
}

