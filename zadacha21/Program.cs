// программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 int x1 = ReadInt("Введите х первой точки: ");
 int y1 = ReadInt("Введите y первой точки: ");
 int z1 = ReadInt("Введите z первой точки: ");
 
 int x2 = ReadInt("Введите х первой точки: ");
 int y2 = ReadInt("Введите y первой точки: ");
 int z2 = ReadInt("Введите z первой точки: ");

Console.WriteLine($"Расстояние между точкой 1 и точкой 2 = {GetLine(x1, y1, z1, x2, y2, z2)}");

int ReadInt(string argument)
{
    Console.Write($"Введите {argument}:");
    int i;
    while (!int.TryParse(Console.ReadLine(), out i ))
    {
        Console.WriteLine("Это не число!");
    }
    return i;
}
double GetLine(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double Line = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
    return Line;
}