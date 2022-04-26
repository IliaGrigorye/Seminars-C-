// Программа которая определяет, присутствует ли заданное число в заданом массиве.
// 4; массив [2, -3] -> нет
// -3; массив [2, -3] -> да
// длина 6


// 1. Ввод числа
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// 2. Создать массив из 16 элементов
int[] array = new int[]{5, 12, 30, 1, 100, -6};
// 3. Вывести массив
PrintArray(array);
// 4. Проверка присутствия
PrintCheck(array);

//---------------------------------------------------------------


// Вывести массив
void PrintArray(int[] arr)
{
    for(int i = 0; i < array.Length; i++)
        if (i == 0)
            Console.Write("в массиве [" + arr[i] + ", ");
        else if (i == array.Length - 1)
            Console.Write(arr[i] + "] ");
        else
            Console.Write(arr[i] + ", ");
}
// Проверка присутствия
void PrintCheck(int[] arr)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(arr[i] == n)
        {
            Console.Write($"присутствует число {n}");
            Environment.Exit(0);
        }
    }
    Console.Write($"не присутствует число {n}");
}