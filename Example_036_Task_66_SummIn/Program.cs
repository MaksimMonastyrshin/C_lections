// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите начальное число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число N = ");
int n = Convert.ToInt32(Console.ReadLine());

if (m>n)
{
    Console.WriteLine("Введены ошибочные значения: M > N.");
}
else
{
    Console.WriteLine($"M = {m}, N = {n} -> {SumNatural(m, n)}");
}

// Метод рекурсивного подсчета суммы натуральных чисел в диапазоне: [paramStart, paramEnd].
int SumNatural(int paramStart, int paramEnd)
{
    int sumNat = paramStart;
    if (paramStart == paramEnd)
    {
        return sumNat;
    }
    return sumNat + SumNatural(paramStart + 1, paramEnd);
}
