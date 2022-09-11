// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] myArray = new int[8];

FillArray(myArray);
PrintArray(myArray, ", ");
Console.Write(" -> [");
PrintArray(myArray, ", ");
Console.Write("]");

void FillArray(int[] paramArray)    //Метод для заполнения переданного массива rnd числами 1 - 99 
{
    int arraySize = paramArray.Length;
    for(int i=0; i < arraySize; i++)
    {
        paramArray[i] = new Random().Next(1, 100);
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