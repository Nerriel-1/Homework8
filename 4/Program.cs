// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int m, int n, int c) // не получилось проверить на одинаковые числа, не знаю как это сделать
{
    int[,,] result = new int[m, n, c];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < c; k++)
            {
                result[i, j, k] = new Random().Next(10, 100);
            }

        }
    }

    return result;
}


void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}




Console.WriteLine("Введите X :");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y :");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z :");
int z = int.Parse(Console.ReadLine());

int[,,] array = GetArray(x, y, z);



PrintArray(array);
Console.WriteLine();
