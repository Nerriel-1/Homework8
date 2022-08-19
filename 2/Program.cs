// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    if (m >= n)
    {
        Console.WriteLine("Введите другие значениея (столбцов должно быть больше строк) ");
    }
    else
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetSumRows(int[,] localArray, int i)
{

    int sumRows = localArray[i, 0];
    for (int j = 1; j < localArray.GetLength(1); j++)
    {
        sumRows += localArray[i, j];
    }
    return sumRows;
}


Console.WriteLine("Введите количество строк массива :");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива :");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);
Console.WriteLine();

int minSumRows = 0;
int sumRows = GetSumRows(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
    int nowSumRows = GetSumRows(array, i);
    if (sumRows > nowSumRows)
    {
        sumRows = nowSumRows;
        minSumRows = i;
    }
}
Console.WriteLine($"{minSumRows + 1} - строкa с min суммой ({sumRows}) ");


