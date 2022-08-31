// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// int number = int.Parse(Console.ReadLine());


Console.Write("Введите первое число, а = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число, b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число, c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("{0}, {1}, {2} -> {3}", a, b, c, max);
