// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {SumDigCount(num)}");
Console.WriteLine();

int SumDigCount(int num) // Метод нахождения суммы чисел всех разрядов
{
    int SumDig = 0;
do  
    {
        SumDig = SumDig + num % 10;
        num = num / 10;
    }
while (num > 0);
return SumDig;
}
