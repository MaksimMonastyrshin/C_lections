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

// Блок заполнения и вывода начального массива на экран.
int minValue = 0;
int maxValue = 9;
int[,] array = new int[inputRows, inputColumns];
FillArray(array, minValue, maxValue);
Console.WriteLine("\nЗаданный массив: ");
PrintIntArray(array, " ");

int[,] array2 = GetNewArray1(array);
PrintIntArray(array2, " ");




int[,] GetNewArray1(int[,] arr)
{
    int[,] newArray = new int[arr.GetLength(0),arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        newArray[newArray.GetLength(0) - 1, j] = arr[0, j];
        newArray[0, j] = arr[newArray.GetLength(0) - 1, j];
    }
    return newArray;
}


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
