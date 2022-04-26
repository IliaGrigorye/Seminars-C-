// Программа замены элементов массива: положительные на отрицательные и наоборот

// 1. Создать массив из 16 элементов
int[] array = new int[6];
// 2. Заполнить его случайными числами от -9 до 9
FillArray(array, -9, 9);
// 3. Вывести массив
PrintArray(array);
// 4. Замена + на -
PrintRevers(array);

//---------------------------------------------------------------

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
// Замена + на - и наоборот
void PrintRevers(int[] arr)
{
    
    for(int i = 0; i < array.Length; i++)
     
        if (i == 0)
            Console.Write("[" + -arr[i] + ", ");
        else if (i == array.Length - 1)
            Console.Write(-arr[i] + "]");
        else
            Console.Write(-arr[i] + ", ");
}