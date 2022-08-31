// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число, а = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число, b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) Console.WriteLine("a = {0}; b = {1} -> max = {0}", a, b);
    else if (b > a) Console.WriteLine("a = {0}; b = {1} -> max = {1}", a, b);
    else Console.WriteLine("Киса, ты наверное питрасян? Числа равны!");
