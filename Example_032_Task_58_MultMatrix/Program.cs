// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

// Блок ввода и проверки данных.
int inputRows = 0;
int inputColumns = 0;
do
{
    Console.Write("Введите первую размерность матриц: ");
    inputRows = int.Parse(Console.ReadLine());
    Console.Write("Введите вторую размерность матриц: ");
    inputColumns = int.Parse(Console.ReadLine());
} while (ErrorFlag(inputRows, inputColumns));

// Блок заполнения и вывода матрицы А на экран.
int minValue = 0;
int maxValue = 9;
int[,] arrayA = new int[inputRows, inputColumns];
FillArray(arrayA, minValue, maxValue);
Console.WriteLine("\n матрица A: ");
PrintIntArray(arrayA, " ");

// Блок заполнения и вывода матрицы В на экран.
int[,] arrayB = new int[inputColumns, inputRows];
FillArray(arrayB, minValue, maxValue);
Console.WriteLine("матрица B: ");
PrintIntArray(arrayB, " ");

// Вычисление произведения матриц А*В и вывод на экран.
int[,] multiplicatedArrays = MultArray(arrayA, arrayB);
Console.WriteLine("произведение матриц A*B: ");
PrintIntArray(multiplicatedArrays, " ");

// Метод проверки введенной размерности массива на корректность.
bool ErrorFlag(int inputR, int inputC)
{
    bool eFlag = false;
    if (inputRows < 1)
    {
        Console.WriteLine("Введено некорректное число! Число должно быть целым, больше 0.");
        eFlag = true;
    }
    if (inputColumns < 1)
    {
        Console.WriteLine("Введено некорректное число! Число должно быть целым, больше 0.");
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

// Метод перемножения двух матриц.
int[,] MultArray(int[,] inArray1, int[,] inArray2)
{
    int rowsAB = inArray1.GetLength(0);
    int columnsAB = inArray2.GetLength(1);
    int multi = inArray1.GetLength(1);
    int[,] arrayAB = new int[rowsAB, columnsAB];
    int sum = 0;

    for (int i = 0; i < rowsAB; i++)
    {
        for (int j = 0; j < columnsAB; j++)
        {
            sum = 0;
            for (int m = 0; m < multi; m++)
            {
                sum = sum + inArray1[i, m] * inArray2[m, j];
            }
            arrayAB[i, j] = sum;
        }
    }
    return arrayAB;
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

int[,] GetNewArray1(int[,] arr)
{
    int[,] newArray = arr;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        newArray[newArray.GetLength(0) - 1, j] = arr[0, j];
        newArray[0, j] = arr[newArray.GetLength(0) - 1, j];
    }

    return newArray;
}