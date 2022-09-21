// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]

Console.Clear();
Console.Write("Введите число элементов в формируемом массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[arraySize];

FillArray(myArray, 0, 100);

// Вывод начального состояния массива.
Console.Write("[");
PrintArray(myArray, ", ");
Console.Write("] -> ");

// Вычисление числа пар элементов массива для перестановки.
int pairsToTurn = arraySize / 2;

// Цикл перестановки пар элементов массива через метод.
for (int i = 0; i < pairsToTurn; i++)
{
    ReplaicePair(myArray, i, arraySize - i - 1);
}

// Вывод результата перестановки.
Console.Write("[");
PrintArray(myArray, ", ");
Console.Write("]");

// Метод перестановки значений для пары указанных элементов массива.
void ReplaicePair(int[] paramArray, int index1, int index2)
{
    int replacer = paramArray[index1];
    paramArray[index1] = paramArray[index2];
    paramArray[index2] = replacer;
}

// Метод для заполнения переданного массива случайными целыми значениями в диапазоне [min, max].
void FillArray(int[] paramArray, int minValue, int maxValue)
{
    // Получение длины массива.
    int arraySize = paramArray.Length;

    Random rnd = new Random();

    // Заполнение массива случайными целыми числами в заданном диапазоне.
    for (int i = 0; i < arraySize; i++)
    {
        paramArray[i] = rnd.Next(minValue, maxValue + 1);
    }
}

// Метод для вывода на экран элементов переданного массива через разделитель.
void PrintArray(int[] paramArray, string delimiter)
{
    int arraySize = paramArray.Length;
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write(paramArray[i]);
        if (i + 1 < arraySize)
        {
            Console.Write(delimiter);
        }
    }
}
