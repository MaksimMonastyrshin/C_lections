// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задание интерфейса для корректной конвертации цифр с десятичными знаками.
using System.Globalization;
IFormatProvider formatter = new NumberFormatInfo();

Console.Clear();
Console.WriteLine("Введите несколько чисел через запятую или пробел: ");
string userString = Console.ReadLine();

// Прогон полученной строки через метод очистки от мусора.
userString = ClearingString(userString);

// Подсчет значений больше нуля из массива чисел, полученного от метода разбивки строки на цифры.
int count = 0;
foreach (double outNumber in Crasher(userString))
{
    if (outNumber > 0)
    {
        count++;
    }
}

Console.WriteLine($"{userString} -> {count}");

// Метод разбивки введенной строки на цифры.
double[] Crasher(string inputedString)
{
    string[] words = inputedString.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
    double[] outNum = new double[words.Length];

    for (int i = 0; i < words.Length; i++)
    {
        outNum[i] = double.Parse(words[i], formatter);
    }

    return outNum;
}

// Метод очистки строки от ' ', '*' и '_' в начале и конце строки.
string ClearingString(string inputString)
{
    string outputStr = inputString.Trim(new char[] {' ', '*', '_'});
    return outputStr;
}
