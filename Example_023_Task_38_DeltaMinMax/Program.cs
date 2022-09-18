// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите число элементов в формируемом массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] myArray = new double[arraySize];
FillArray(myArray, -100, 101);
Console.Write("[");
PrintArray(myArray, ", ");
Console.Write("] -> ");
double MinElement = 0;
double MaxElement = 0;
FindMinMax(myArray, out MinElement, out MaxElement);
Console.WriteLine(MaxElement - MinElement);

void FindMinMax(double[] paramArray, out double MinEl, out double MaxEl)
{
    MaxEl = 0;
    MinEl = 0;
    foreach (double el in paramArray)
    {
        if (el > MaxEl) MaxEl = el;
        if (el < MinEl) MinEl = el;
    }
}

void FillArray(double[] paramArray, int minValue, int maxValue)    //Метод для заполнения переданного массива rnd значениями в диапазоне [min, max]
{
    int arraySize = paramArray.Length;
    for (int i = 0; i < arraySize; i++)
    {
        paramArray[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
    }
}

void PrintArray(double[] paramArray, string delimiter)    //Метод для вывода на экран элементов переданного массива через разделитель
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
