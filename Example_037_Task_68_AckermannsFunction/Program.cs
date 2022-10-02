// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
//
//          n+1, если m=0;
// A(m,n) = A(m-1, 1), если m<>0, n=0;
//          A(m-1, A(m, n-1)), если m>0, n>0.
//
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите натуральное число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {m}, N = {n} -> A({m}, {n}) = {Ackermann(m, n)}");

// Метод рекурсировного вычисления функции Аккермана.
long Ackermann(long paramM, long paramN)
{
    if (paramM == 0)
    {
        return paramN + 1;
    }
    else if (paramN == 0)
    {
        return Ackermann(paramM - 1, 1);
    }
    else
    {
        return Ackermann(paramM - 1, Ackermann(paramM, paramN - 1));
    }
}
