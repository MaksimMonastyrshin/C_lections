// Задача 23: Напишите программу, которая принимает на вход число (N) и
// выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число для раскладки на кубы: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.Write($"{num} -> ");

while(count<num)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
    count++;
}
Console.WriteLine(Math.Pow(num, 3));
