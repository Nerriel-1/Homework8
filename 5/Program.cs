//  Заполните спирально массив 4 на 4.
//Код не мой, но логику поняла
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

int[,] GetArray(int size)
{
    int[,] a = new int[4, 4];
    int n = 4;
    int m = 4;


    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= n * m)
    {
        a[i, j] = k;
        if (i == Ibeg && j < m - Jfin - 1)
            ++j;
        else if (j == m - Jfin - 1 && i < n - Ifin - 1)
            ++i;
        else if (i == n - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != m - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }


    return a;
}



PrintArray(GetArray(4));