// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int LeftDigit1 = num / 10000;
int LeftDigit2 = (num % 10000) / 1000;
int RightDigit1 = num % 10;
int RightDigit2 = (num % 100) / 10;
if(LeftDigit1 == RightDigit1 && LeftDigit2 == RightDigit2)
{
    Console.WriteLine($"{num} -> да");
}
else
{
    Console.WriteLine($"{num} -> нет");
}
