// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// p.s. Если в метод UpChar() подставить настрочные Unicode символы, то степень бы красиво собиралась точно как в задаче, причем любое натуральное число,
// но я перепробвал всё, что знал - консоль упорно заменяет надстрочные символы знаками "?". Пришлось заменить их обычными 0-9

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

Console.WriteLine($"{a}, {b} -> {result} ({a}^{UpString(b)})");
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
        num = num / 10;
    }
while (num > 0);
return ExpUpString;
}

string UpChar(int Dig1)  // метод преобразует цифры в диапазоне [0-9] в надстрочные ⁰¹²³⁴⁵⁶⁷⁸⁹ цифры Unicode
{
    string CharUp = string.Empty;
    if (Dig1 == 0)
    {
        CharUp = "0";
    }
    else if (Dig1 == 1)
    {
        CharUp = "1";
    }
    else if (Dig1 == 2)
    {
        CharUp = "2";
    }
    else if (Dig1 == 3)
    {
        CharUp = "3";
    }
    else if (Dig1 == 4)
    {
        CharUp = "4";
    }
    else if (Dig1 == 5)
    {
        CharUp = "5";
    }
    else if (Dig1 == 6)
    {
        CharUp = "6";
    }
    else if (Dig1 == 7)
    {
        CharUp = "7";
    }
    else if (Dig1 == 8)
    {
        CharUp = "8";
    }
    else if (Dig1 == 9)
    {
        CharUp = "9";
    }
    return CharUp;
}