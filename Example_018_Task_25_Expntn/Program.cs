// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Введите основание (число, которое будет возведено в степень): ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
double result = 1;
int count = 0;
while (count < b)
{
    result = result * a;
    count ++;
}
Console.WriteLine($"{a}, {b} -> {result} ({a}{UpString(b)})");
Console.WriteLine();

string UpString(int num) // Метод UpString() для преобразования и вывода целого числа [0 - N] в виде строки надстрочными цифрами Unicode таблицы
{
    string ExpUpString = String.Empty;
    int TakelastDigit = 0;
    // разбираем целое число аргумент поразрядно
    // для каждого числа разряда (0-9) подбираем надстрочный элемент Unicode через вызов UpChar()
    // склеиваем всё в возващаемую строковую переменную ExpUpString

    do  // проверяем, если деление на 10 больше 0, значит есть еще один разряд выше и можно работать с единицами, если равен 0, значит в аргументе остался один разряд
    {
        TakelastDigit = num % 10;
        ExpUpString = UpChar(TakelastDigit) + ExpUpString;
        num = num / 10; // откусываем справа обработанный разряд
    }
while (num > 0);
return ExpUpString;
}
string UpChar(int Dig1)  // метод преобразует цифры в диапазоне [0-9] в надстрочные ⁰¹²³⁴⁵⁶⁷⁸⁹ цифры Unicode
{
    string CharUp = string.Empty;
    if (Dig1 == 0)
    {
        CharUp = "⁰";
    }
    else if (Dig1 == 1)
    {
        CharUp = "¹";
    }
    else if (Dig1 == 2)
    {
        CharUp = "²";
    }
    else if (Dig1 == 3)
    {
        CharUp = "³";
    }
    else if (Dig1 == 4)
    {
        CharUp = "⁴";
    }
    else if (Dig1 == 5)
    {
        CharUp = "⁵";
    }
    else if (Dig1 == 6)
    {
        CharUp = "⁶";
    }
    else if (Dig1 == 7)
    {
        CharUp = "⁷";
    }
    else if (Dig1 == 8)
    {
        CharUp = "⁸";
    }
    else if (Dig1 == 9)
    {
        CharUp = "⁹";
    }
    return CharUp;
}