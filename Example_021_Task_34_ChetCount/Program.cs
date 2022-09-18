// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве. 
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите число элементов в формируемом массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arraySize];
FillArray(myArray, 100, 999);
Console.Write("[");
PrintArray(myArray, ", ");
Console.Write("] -> ");
Console.Write(ChetCount(myArray));

int ChetCount(int[] paramArray) //Метод подсчета количества элементов массива с четными значениями. 
{
    int counter = 0;
    foreach (int el in paramArray)
    {
        if ((el%2) == 0)
        {
            counter++;
        }
    }
    return counter;
}

void FillArray(int[] paramArray, int minValue, int maxValue)    //Метод для заполнения переданного массива rnd значениями в диапазоне [min, max]
{
    int arraySize = paramArray.Length;
    for(int i=0; i < arraySize; i++)
    {
        paramArray[i] = new Random().Next(minValue, maxValue+1);
    }
}

void PrintArray(int[] paramArray, string delimiter)    //Метод для вывода на экран элементов переданного массива через разделитель
{
    int arraySize = paramArray.Length;
    for(int i=0; i < arraySize; i++)
    {
        Console.Write(paramArray[i]);
        if(i+1 < arraySize)
        {
            Console.Write(delimiter);
        }
    } 
}
