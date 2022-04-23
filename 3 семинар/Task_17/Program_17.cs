//Программа которая принимает на вход кординаты точки (x, y), причем x,y != 0
//и выдает номер четверти плоскости, в которой находиться эта точка

Console.Write("Enter cordinates (x): ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter cordinates (y): ");
int y = Convert.ToInt32(Console.ReadLine());

int q = getQuadrant(x, y);

if (q == 0){
    Console.WriteLine("This point is on ax");
} else {
    Console.WriteLine("This point is in quadrant #" + q);
}

//get quadrant number for the point
int getQuadrant(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;
    
    return 0;
}