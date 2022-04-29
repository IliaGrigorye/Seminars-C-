// ользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

PrintArray(arr);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] > 0)
    {
        count++;
    }
}

Console.Write(count);

void PrintArray(int[] arr)
{
    Console.Write("из чисел (");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if(i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.Write(") больше нуля ");
}