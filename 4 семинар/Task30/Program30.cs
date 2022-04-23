// Программа которая выводит массив из 8 элементов, заполненый 0 и 1 в случайном порядке

//int[] array = new int[8];
//for (int i = 0; i <= array.Length - 1; i++)
//{
//    array[i] = new Random().Next(0, 2);
//    Console.Write(array[i] + "; ");
//}
//Console.WriteLine();

int[] array = new int[8];
Random rand = new Random();
for(int i = 0; i < array.Length; i++){
    array[i] = rand.Next(0, 2);
    if (i == 0)
        Console.Write("[" + array[i] + "; ");
    else if (i == array.Length - 1)
        Console.Write(array[i] + "]");
    else
        Console.Write(array[i] + "; ");
}