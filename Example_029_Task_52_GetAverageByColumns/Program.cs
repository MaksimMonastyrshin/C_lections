// Задача 52:
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// Блок заполнения и вывода массива на экран.
int minValue = 0;
int maxValue = 1000;
int[,] array = new int[inputRows, inputColumns];
FillArray(array, minValue, maxValue);
PrintIntArray(array, "\t");

// Вычисление средних значений по столбцам.
double[] columnsAverage = new double[inputColumns];
for (int i = 0; i < inputColumns; i++)
{
    columnsAverage[i] = CalcAvgArrayColumn(array, i);
}

// Вывод результатов.
Console.Write("Среднее арифметическое каждого столбца: ");
PrintDoubleArray(columnsAverage, ", ");
Console.WriteLine();

// Методы:

// Метод проверки введенной размерности массива на корректность.

// Метод вычисления средних значений в столбцах 2D массива и вывод в отдельный массив
double CalcAvgArrayColumn(int[,] paramArray, int paramColumn)
{
    int rowsInAray = paramArray.GetLength(0);
    double sum = 0;
    for (int i = 0; i < rowsInAray; i++)
    {
        sum = sum + paramArray[i, paramColumn];
    }
    return (sum / rowsInAray);
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

// Метод для вывода на экран элементов переданного 2D массива через разделитель.
void PrintDoubleArray(double[] paramArray, string delimiter)
{
    int size = paramArray.Length;
     for (int i = 0; i < size; i++)
    {
        Console.Write(string.Format("{0:f1}", paramArray[i]));
        if (i + 1 < size)
        {
            Console.Write(delimiter);
        }
    }
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
