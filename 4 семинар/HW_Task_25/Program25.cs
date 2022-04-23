// Программа которая принимает на вход два числа (A и B) и возводит число A в натуральную степень В
// 2,4 -> 16
// 3,5 -> 243

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа A: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write(Math.Pow(A, B));