// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();
Console.Write("Введите начальное число N = ");
int n = Convert.ToInt32(Console.ReadLine());

// Если введенное число n НЕчетное, то уменьшаем его на единицу.
if (n % 2 != 0) n--;
EvenDown(n);

// Рекурсивный метод вывода четных чисел на консоль.
void EvenDown(int paramEven)
{
    if (paramEven > 1)
    {
        Console.Write(paramEven);
        if ((paramEven - 2) > 1)
        {
            Console.Write(", ");
        }
        EvenDown(paramEven - 2);
    }
}
