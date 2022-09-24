// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

// Задание целочисленного 2D массива.
// Блок ввода и проверки данных.
int inputRows = 0;
int inputColumns = 0;
do
{
    Console.Write("Введите число строк в создаваемом массиве: ");
    inputRows = int.Parse(Console.ReadLine());
    Console.Write("Введите число столбцов в создаваемом массиве: ");
    inputColumns = int.Parse(Console.ReadLine());
} while (ErrorFlag(inputRows, inputColumns));

// Блок заполнения и вывода массива на экран.
int minValue = 0;
int maxValue = 1000;
int[,] array = new int[inputRows, inputColumns];
FillArray(array, minValue, maxValue);
PrintArray(array, "\t");

// Блок ввода позиции искомого элемента массива.

Console.Write("Введите через запятую позицию искомого элемента массива (Row, Col): ");
string userString = Console.ReadLine();

// Прогон полученной строки через метод очистки от мусора.
userString = ClearingString(userString);

// Получение массива значений координат.
int[] outNumber = Crasher(userString);

// Проверка введенных значений, полученных от метода разбивки строки на цифры, вывод результата.
if (outNumber.Length == 2)
{
    // Проверка координат и вывод результата.
    if ((outNumber[0] > 0) && (outNumber[0] <= inputRows) && (outNumber[1] > 0) && (outNumber[1] <= inputColumns))
    {
        Console.WriteLine($"В строке {outNumber[0]} столбца {outNumber[1]} значение: {array[(outNumber[0] - 1), (outNumber[1] - 1)]}");
    }
    else
    {
        Console.WriteLine("Введенная позиция выходит за пределы размеров массива.");
    }
}
else
{
    Console.WriteLine("Должно быть введено 2 целых числа через запятую!");
}

// Методы:

// Метод проверки введенной размерности массива на корректность.
bool ErrorFlag(int inputR, int inputC)
{
    bool eFlag = false;
    if (inputRows < 1)
    {
        Console.WriteLine("Введено некорректное число строк! Число должно быть целым, больше 0.");
        eFlag = true;
    }
    if (inputColumns < 1)
    {
        Console.WriteLine("Введено некорректное число столбцов! Число должно быть целым, больше 0.");
        eFlag = true;
    }
    return eFlag;
}

// Метод заполнения 2D массива случайными целыми значениями в диапазоне [min, max].
void FillArray(int[,] paramArray, int minValue, int maxValue)
{
    int rows = paramArray.GetLength(0);
    int columns = paramArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            paramArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

// Метод для вывода на экран элементов переданного 2D массива через разделитель.
void PrintArray(int[,] paramArray, string delimiter)
{
    int rows = paramArray.GetLength(0);
    int columns = paramArray.GetLength(1);

    Console.WriteLine();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(paramArray[i, j]);
            if (j + 1 < columns)
            {
                Console.Write(delimiter);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод очистки строки от ' ', '*' и '_' в начале и конце строки.
string ClearingString(string inputString)
{
    string outputStr = inputString.Trim(new char[] { ' ', '*', '_' });
    return outputStr;
}

// Метод разбивки введенной строки на цифры.
int[] Crasher(string inputedString)
{
    string[] words = inputedString.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
    int[] outNum = new int[words.Length];

    for (int i = 0; i < words.Length; i++)
    {
        outNum[i] = int.Parse(words[i]);
    }

    return outNum;
}
