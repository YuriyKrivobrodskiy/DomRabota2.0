// программа,которая принимает на вход число (N) и выдаёт таблицу кубов числа N

int N = ReadInt("Введите число: ");
System.Console.WriteLine(string.Join(", ", Square(N)));
int ReadInt(string argument)
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(),out i))
    {
        Console.WriteLine("Это не число!");
    }
    return i;
}
int [] Square( int N )
{
    int [] S = new int[N];
    for ( int i = 0; i < N; i++ )
    {
        S[i] = (int)Math.Pow( i, 3 );
    }
    return S;
}