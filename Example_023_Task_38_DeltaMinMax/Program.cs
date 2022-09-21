// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите число элементов в формируемом массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] myArray = new double[arraySize];
FillArray(myArray, -100, 100);
Console.Write("[");
PrintArray(myArray, ", ");
Console.Write("] -> ");
double minElement = 0;
double maxElement = 0;
FindMinMax(myArray, out minElement, out maxElement);
Console.WriteLine(maxElement - minElement);

// Метод для поиска и вывода максимального и минимального значения элементов массива.
void FindMinMax(double[] paramArray, out double minEl, out double maxEl)
{
    maxEl = 0;
    minEl = 0;
    foreach (double el in paramArray)
    {
        if (el > maxEl) maxEl = el;
        if (el < minEl) minEl = el;
    }
}

// Метод для заполнения переданного массива rnd значениями в диапазоне [min, max].
void FillArray(double[] paramArray, int minValue, int maxValue)
{
    int arraySize = paramArray.Length;
    for (int i = 0; i < arraySize; i++)
    {
        paramArray[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
    }
}

// Метод для вывода на экран элементов переданного массива через разделитель.
void PrintArray(double[] paramArray, string delimiter)
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
