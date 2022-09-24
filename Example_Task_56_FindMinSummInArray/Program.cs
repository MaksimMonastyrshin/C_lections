// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

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

// Блок заполнения и вывода начального массива на экран.
int minValue = 0;
int maxValue = 9;
int[,] array = new int[inputRows, inputColumns];
FillArray(array, minValue, maxValue);
Console.WriteLine("\nЗаданный массив: ");
PrintIntArray(array, " ");

// Заполнение массива сумм по каждой строке.
int[] rowSum = new int[inputRows];
for (int i = 0; i < inputRows; i++)
{
    rowSum[i] = CountRowSum(array, i);
}

// Вывод номера строки с наименьшей суммой из массива rowSum.
int MinSumIndex = FindMinIndex(rowSum);
Console.WriteLine($"В строке: {(MinSumIndex + 1)} - наименьшая сумма элементов ({rowSum[MinSumIndex]}).");
Console.WriteLine();

// Метод подсчета суммы элементов строки массива.
int CountRowSum(int[,] array, int inputRow)
{
    int result = array[inputRow, 0];
    for (int i = 1; i < array.GetLength(1); i++)
    {
        result = result + array[inputRow, i];
    }
    return result;
}

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

// Метод поиска и вывода индекса минимального элемена массива.
int FindMinIndex(int[] array)
{
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
}

// Метод для вывода на экран элементов переданного 2D целочисленного массива через разделитель.
void PrintIntArray(int[,] paramArray, string delimiter)
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
