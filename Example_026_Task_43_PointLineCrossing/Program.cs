// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Задание интерфейса для корректной конвертации цифр с десятичными знаками.
using System.Globalization;
IFormatProvider formatter = new NumberFormatInfo();

Console.Clear();
Console.WriteLine("Введите параметры уравнений b1, k1, b2, k2 через запятую: ");
string userString = Console.ReadLine();

// Прогон полученной строки через метод очистки от мусора.
userString = ClearingString(userString);

// Получение массива значений координат.
double[] outNumber = Crasher(userString);

// Проверка введенных значений, полученных от метода разбивки строки на цифры.
if (outNumber.Length == 4)
{
    // Раскладка значений, вычисление и вывод координат.
    double b1 = outNumber[0];
    double k1 = outNumber[1];
    double b2 = outNumber[2];
    double k2 = outNumber[3];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
else
{
    Console.WriteLine("Должно быть введено 4 значения!");     
}

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
