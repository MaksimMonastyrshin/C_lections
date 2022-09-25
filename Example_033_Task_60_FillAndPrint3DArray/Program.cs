// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

// Блок ввода и проверки данных.
int inputX = 0;
int inputY = 0;
int inputZ = 0;
do
{
    Console.Write("Введите размерность массива X : ");
    inputX = int.Parse(Console.ReadLine());
    Console.Write("Введите размерность массива Y: ");
    inputY = int.Parse(Console.ReadLine());
    Console.Write("Введите размерность массива Z: ");
    inputZ = int.Parse(Console.ReadLine());
} while (ErrorFlag(inputX, inputY, inputZ));

// Блок заполнения массива двузначными неповторяющимися числами.
int minValue = 10;
int[,,] array3D = new int[inputX, inputY, inputZ];
Fill3DArray(array3D, minValue);

// Блок вывода значений и индексов массива на экран, построчно.
Console.WriteLine($"\n Массив размером {inputX} x {inputY} x {inputZ}: ");
PrintIntArray(array3D, " ");

// Метод проверки введенной размерности массива на корректность.
bool ErrorFlag(int paramX, int paramY, int paramZ)
{
    bool eFlag = false;
    if (paramX < 1 || paramY < 1 || paramZ < 1)
    {
        Console.WriteLine("Введено некорректное число! Число должно быть целым, больше 0.");
        eFlag = true;
    }
    if ((paramX * paramY * paramZ) > 90)
    {
        Console.WriteLine($"Заданный массив [{paramX}, {paramY}, {paramZ}] невозможно заполнить неповторяющимися 2-значными числами."); 
        Console.WriteLine($"Число элементов массива [{paramX * paramY * paramZ}] больше 90.");
        Console.WriteLine();
        eFlag = true;
    }
    return eFlag;
}

// Метод заполнения 3D массива двузначными неповторяющимися числами, начиная со значения inputMin.
void Fill3DArray(int[,,] paramArray, int inputMin)
{
    int paramX = paramArray.GetLength(0);
    int paramY = paramArray.GetLength(1);
    int paramZ = paramArray.GetLength(2);
    int count = inputMin;
    for (int x = 0; x < paramX; x++)
    {
        for (int y = 0; y < paramY; y++)
        {
            for (int z = 0; z < paramZ; z++)
            {
                paramArray[x, y, z] = count;
                count++;
            }
        }
    }
}

// Метод вывода на консоль значений и индексов 3D массива через разделитель построчно.
void PrintIntArray(int[,,] paramArray, string delimiter)
{
    int paramX = paramArray.GetLength(0);
    int paramY = paramArray.GetLength(1);
    int paramZ = paramArray.GetLength(2);
    Console.WriteLine();

    for (int z = 0; z < paramZ; z++)
    {
        for (int y = 0; y < paramY; y++)
        {
            for (int x = 0; x < paramX; x++)
            {
                Console.Write($"{paramArray[x, y, z]}({x},{y},{z})");
                if (x + 1 < paramX)
                {
                    Console.Write(delimiter);
                }
            }
            Console.WriteLine(); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}