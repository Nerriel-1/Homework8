//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
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

void ReverseArray(int[,] localArray)
{
   
  for (int i = 0; i < localArray.GetLength(0); i++)
  {
    for (int j = 0; j < localArray.GetLength(1); j++)
    {
      for (int k = 0; k < localArray.GetLength(1) - 1; k++)
      {
        if (localArray[i, k] < localArray[i, k + 1])
        {
          int n = localArray[i, k + 1];
          localArray[i, k + 1] = localArray[i, k];
          localArray[i, k] = n;
        }
      }
    }
  }
  PrintArray(localArray);
}

Console.WriteLine("Введите количество строк массива :");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива :");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);
Console.WriteLine();
ReverseArray(array);
