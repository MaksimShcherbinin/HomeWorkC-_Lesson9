int[,] CreateAndFillMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("Введите результат {0} броска для {1} игрока: "
            , j + 1, i + 1);
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }

    }
    return matrix;
}

void SumRowMatrix(int[,] matrix)
{
    Console.WriteLine();
    
    int maxrow = 0;
    int maxid = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow = sumrow + matrix[i, j];
        }
        if (sumrow > maxrow)
        {
            maxrow = sumrow;
            maxid = i + 1;
        }
    }
    Console.WriteLine("Сумма: {0} Спортсмен №{1}", maxrow, maxid);
}

Console.Write("Введите кол-во спортсменов: ");
int numAthletes = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во бросков: ");
int numThrows = Convert.ToInt32(Console.ReadLine());

SumRowMatrix(CreateAndFillMatrix(numAthletes, numThrows));
