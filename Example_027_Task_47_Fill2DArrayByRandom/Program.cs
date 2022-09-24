// Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

// Заполнение массива.
int minValue = 0;
int maxValue = 100;
double[,] array = new double[inputRows, inputColumns];
FillArray(array, minValue, maxValue);

// Вывод массива на экран через заданный разделитель - горизонтальный табулятор.
PrintArray(array, "\t");

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

// Метод заполнения 2D массива случайными вещественными значениями в диапазоне [min, max].
void FillArray(double[,] paramArray, int minValue, int maxValue)
{
    int rows = paramArray.GetLength(0);
    int columns = paramArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            paramArray[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
        }
    }
}

// Метод для вывода на экран элементов переданного 2D массива через разделитель.
void PrintArray(double[,] paramArray, string delimiter)
{
    int rows = paramArray.GetLength(0);
    int columns = paramArray.GetLength(1);

    Console.WriteLine();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(string.Format("{0:f3}", paramArray[i, j]));
            if (j + 1 < columns)
            {
                Console.Write(delimiter);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
