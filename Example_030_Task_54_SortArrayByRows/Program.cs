// Задача 54:
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:              В итоге получается вот такой массив:
// 1 4 7 2                              7 4 2 1
// 5 9 2 3                              9 5 3 2
// 8 4 2 4                              8 4 4 2

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

// Цикл передачи каждой строки массива в метод сортировки.
for (int i = 0; i < inputRows; i++)
{
    SortArrayRowDown(array, i);
}

// Вывод отсортированного массива.
Console.WriteLine("Отсортированный массив: ");
PrintIntArray(array, " ");

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

// Метод сортировки строк массива по убыванию. 
// Параметры: (массив, индекс строки для сортировки)
void SortArrayRowDown(int[,] paramArray, int inRow)
{
    int size = paramArray.GetLength(1);
    int maxIndex = 0;
    int temp = 0;
    for (int i = 0; i < (size - 1); i++)
    {
        for (int j = (i + 1); j < size; j++)
        {
            if (paramArray[inRow, j] > paramArray[inRow, i])
            {
                temp = paramArray[inRow, i];
                paramArray[inRow, i] = paramArray[inRow, j];
                paramArray[inRow, j] = temp;

            }
        }
    }
}