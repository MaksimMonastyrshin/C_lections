// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите конечное число = ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 2) Console.WriteLine($"В диапазоне от 1 до {a} четных чисел нет"); // проверка на нижний предел
else
{
    int count = 2;
    Console.Write($"{a} -> ");

    while ((count < a) || (count == a))
    {
        Console.Write(count);
        count += 2;
        if ((count < a) || (count == a)) Console.Write(", "); // если СЛЕДУЮЩЕЕ четное число меньше или равно А, то к текущему добавляем разделитель
    }
}
