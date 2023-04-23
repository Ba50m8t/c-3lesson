Console.Write("введите x1   ");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("введите y1   ");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("введите z1   ");
int z1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("введите x2   ");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("введите y2   ");
int y2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("введите z2   ");
int z2 = int.Parse(Console.ReadLine() ?? "");

double distance = GetDistance(x1, y1, z1, x2, y2, z2); ;
Console.WriteLine(distance);

static double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distance;
}