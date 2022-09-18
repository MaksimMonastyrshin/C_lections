/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.Write("Введите число элементов в формируемом массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arraySize];
FillArray(myArray, -100, 101);
Console.Write("[");
PrintArray(myArray, ", ");
Console.Write("] -> ");
Console.Write(SumNechet(myArray));

int SumNechet(int[] paramArray)    //Метод подсчета и возврата суммы элементов с нечетными индексами.
{
    int sumNech = 0;
    for (int i = 1; i < paramArray.Length; i += 2)
    {
        sumNech += paramArray[i];
    }
    return sumNech;
}

void FillArray(int[] paramArray, int minValue, int maxValue)    //Метод для заполнения переданного массива rnd значениями в диапазоне [min, max]
{
    int arraySize = paramArray.Length;
    for (int i = 0; i < arraySize; i++)
    {
        paramArray[i] = new Random().Next(minValue, maxValue + 1);
    }
}

void PrintArray(int[] paramArray, string delimiter)    //Метод для вывода на экран элементов переданного массива через разделитель
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