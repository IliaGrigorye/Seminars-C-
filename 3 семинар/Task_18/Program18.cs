//Програма которая по заданому номеру четверти показывает возможные кординаты точек в этой четверти

Console.Write("Введите номер четверти (q): ");
int q = Convert.ToInt32(Console.ReadLine());
string res = diaposon(q);
Console.WriteLine(res);
string diaposon(int q)
{
    if (q == 1)
        return "X>0 Y>0";
    if (q == 2)
        return "X<0 Y>0";
    if (q == 3)
        return "X<0 Y<0";
    if (q == 4)
        return "X>0 Y<0";

    return "Введите число от 1 до 4";
}