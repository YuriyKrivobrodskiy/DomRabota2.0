// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом/
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;
if ( len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} - палиндром.");
    }
    else
    {
    Console.WriteLine($"Число {number} - не палиндром.");
    }
}
else 
{
    Console.WriteLine("Вы ввели не корректное число. Введите пятизначное число.");
}    
