// Программа которая задаёт массив из 8 случайных целых чисел и выводит их на экран. 
// Диапазон - любое целое число.

int[] array = new int[8];
Random rand = new Random();
for(int i = 0; i < array.Length; i++){
    array[i] = rand.Next(-10000, 10000);
    if (i == 0)
        Console.Write("[" + array[i] + ", ");
    else if (i == array.Length - 1)
        Console.Write(array[i] + "]");
    else
        Console.Write(array[i] + ", ");
}
