// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double[] numbers = GetStringToNum();
PrintArray(numbers);
Console.WriteLine();
double[] GetStringToNum()
{
    double[] num = StringToNum(Console.ReadLine());
    if (num.Length != 4)
    {
        Console.WriteLine("Введено недопустимое значение, введите 4 натуральных числа через запятую");
    }
    else
    {
        double x = 0;
        double y = 0;
        x = (num[2] - num[0]) / (num[1] - num[3]);
        y = num[1] * x + num[0];
        Console.WriteLine($"Точка пересечения ( {x} ; {y} )");
    }
    return num;
}

// Метод
double[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    double[] num = new double[count];
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";
        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp = temp + input[i].ToString(); // x=x+y и х+=у
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        num[index] = Convert.ToDouble(temp);
        index++;
    }
    return num;
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write(" ]");
}
