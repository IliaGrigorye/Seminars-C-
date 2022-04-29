// Программа которая переворачивает одномерный массив
// [1 2 3 4 5] -> [5 4 3 2 1]

int[] arr = {10, 25, 46, 76, 100, 321, 540};


ReverseArrayInPlace(arr);





//int[] tmp = ReverseArray(arr);

//CopyArray(tmp, arr);

PrintArray(arr);

void ReverseArrayInPlace(int [] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}










int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        result[array.Length - 1 - i] = array[i];
    
    return result;
}

void CopyArray(int[] source, int[] dest)
{
    if (source.Length != dest.Length)
        return;

    for (int i = 0; i < source.Length; i++)
        dest[i] = source[i];
}

void PrintArray(int[] arr)
{
    Console.Write("{");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if(i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.Write("}");
}