//  программа которая будет преобразовывать десятичное число в двоичное.
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int step = n; step > 0; step /= 2)
{
    count++;
}

int[] arr = new int[count];
 
for (int i = 0, step = n; step > 0; step /= 2)
{
    arr[i] = step % 2;
    i++;
}

Console.Write($"{n} -> ");

for (int i = count - 1; i >= 0; i--)
{
    Console.Write(arr[i]);
};

