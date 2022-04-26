// Программа находящая сумму элементов массива, стоящих на нечётных позициях. Длина массива задается с терминала.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//------------------------------------------------------------------------------------

// 1. Создать массив из n элементов
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// 2. Заполнить его случайными положительными трехзначными числами
FillArray(array, -99, 99);
// 3. Вывести массив
PrintArray(array);
// 4. Подсчет суммы элементов стоящих на нечетных позициях и вывод
PrintQuan(array);

//-------------------------------------------------------------------------

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

// Найти сумму
void PrintQuan(int[] arr)

{
    int k = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0 )
        {
            k = k + arr[i];
        }
    }
    Console.Write(k);
}
