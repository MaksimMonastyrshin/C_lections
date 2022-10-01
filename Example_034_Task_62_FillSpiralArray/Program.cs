// Задача 62.
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

// Блок ввода и проверки данных.
int inputRows = 0;
int inputColumns = 0;
do
{
    Console.Write("Введите количество строк в массиве : ");
    inputRows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов в массиве : ");
    inputColumns = int.Parse(Console.ReadLine());
} while (ErrorFlag(inputRows, inputColumns));

// Блок заполнения массива числами по спирали.
int[,] array2D = new int[inputRows, inputColumns];
int positionRow = 0;
int positionCol = -1;
int currentValue = 0;
bool moveRight = true;
bool moveDown = false;
bool moveLeft = false;
bool moveUp = false;

// Пока есть возможность движения хотя бы в одном направлении - выполняем заполнение ряда.
while (moveRight == true || moveDown == true || moveLeft == true || moveUp == true)
{
    moveDown = FillToRight(array2D, ref positionRow, ref positionCol, ref currentValue);
    moveLeft = FillToDown(array2D, ref positionRow, ref positionCol, ref currentValue);
    moveUp = FillToLeft(array2D, ref positionRow, ref positionCol, ref currentValue);
    moveRight = FillToUp(array2D, ref positionRow, ref positionCol, ref currentValue);
}

// Вывод заполненного массива на экран.
PrintIntArray(array2D, " ");

// Метод проверки введенной размерности массива на корректность.
bool ErrorFlag(int paramX, int paramY)
{
    bool eFlag = false;
    if (paramX < 1 || paramY < 1)
    {
        Console.WriteLine("Введено некорректное число! Число должно быть целым, больше 0.");
        Console.WriteLine();
        eFlag = true;
    }
    return eFlag;
}

// Метод заполнения строки вправо.
bool FillToRight(int[,] paramArray2D, ref int posR, ref int posC, ref int curVal)
{
    // Пока справа есть элемент и он пуст (равен 0), то заполняем его и передвигаем позицию.
    bool moveDn = true;
    while ((posC + 1) < paramArray2D.GetLength(1) && paramArray2D[posR, (posC + 1)] == 0)
    {
        posC = posC + 1;
        curVal = curVal + 1;
        paramArray2D[posR, posC] = curVal;
    }
    // Проверка на возможность двигаться дальше по спирали вниз.
    if ((posR + 1) >= paramArray2D.GetLength(0) || paramArray2D[(posR + 1), posC] != 0)
    {
        moveDn = false;
    }
    return moveDn;
}

// Метод заполнения строки вниз.
bool FillToDown(int[,] paramArray2D, ref int posR, ref int posC, ref int curVal)
{
    // Пока внизу есть элемент и он пуст (равен 0), то заполняем его и передвигаем позицию вниз.
    bool moveL = true;
    while ((posR + 1) < paramArray2D.GetLength(0) && paramArray2D[(posR + 1), posC] == 0)
    {
        posR = posR + 1;
        curVal = curVal + 1;
        paramArray2D[posR, posC] = curVal;
    }
    // Проверка на возможность двигаться дальше по спирали влево.
    if ((posC - 1) < 0 || paramArray2D[posR, (posC - 1)] != 0)
    {
        moveL = false;
    }
    return moveL;
}

// Метод заполнения строки влево.
bool FillToLeft(int[,] paramArray2D, ref int posR, ref int posC, ref int curVal)
{
    // Пока слева есть элемент и он пуст (равен 0), то заполняем его и передвигаем позицию влево.
    bool moveU = true;
    while ((posC - 1) >= 0 && paramArray2D[posR, (posC - 1)] == 0)
    {
        posC = posC - 1;
        curVal = curVal + 1;
        paramArray2D[posR, posC] = curVal;
    }
    // Проверка на возможность двигаться дальше по спирали вверх.
    if ((posR - 1) < 0 || paramArray2D[(posR - 1), posC] != 0)
    {
        moveU = false;
    }
    return moveU;
}

// Метод заполнения строки вверх.
bool FillToUp(int[,] paramArray2D, ref int posR, ref int posC, ref int curVal)
{
    // Пока выше есть элемент и он пуст (равен 0), то заполняем его и передвигаем позицию вверх.
    bool moveR = true;
    while ((posR - 1) >= 0 && paramArray2D[(posR - 1), posC] == 0)
    {
        posR = posR - 1;
        curVal = curVal + 1;
        paramArray2D[posR, posC] = curVal;
    }
    // Проверка на возможность двигаться дальше по спирали вправо.
    if ((posC + 1) >= paramArray2D.GetLength(1) || paramArray2D[posR, (posC + 1)] != 0)
    {
        moveR = false;
    }
    return moveR;
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
            Console.Write(string.Format("{0:d2}", paramArray[i, j]));
            if (j + 1 < columns)
            {
                Console.Write(delimiter);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

