// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Не смогла разобрать что не так
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    if (m > n)
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

void GetMultiplicationMatrix(int[,] arr1, int[,] arr2, int[,] resultArr)
{
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            resultArr[i, j] = sum;
        }
    }
}


Console.WriteLine("Введите количество строк 1 массива :");
int rows1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 1 массива :");
int columns1 = int.Parse(Console.ReadLine());

int[,] array1 = GetArray(rows1, columns1, 0, 9);

Console.WriteLine("Введите количество строк 2 массива :");
int rows2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 2 массива :");
int columns2 = int.Parse(Console.ReadLine());

int[,] array2 = GetArray(rows2, columns2, 0, 9);
int[,] resultArray = new int[rows1, columns2];


PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
GetMultiplicationMatrix(array1, array2, resultArray);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultArray);