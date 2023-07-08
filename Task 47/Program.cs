// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

System.Console.WriteLine("Двумерный массив заполненный случайными вещественными числами: ");

void Array()
{
    double[,] array = FillArray(3, 4, -10, 10);
    PrintArray(array);
}

double[,] FillArray(int column, int row, int startRange, int endRange)
{
    double[,] array = new double[row, column];
    Random rand = new Random();
    for (int a = 0; a < row; a++)
    {
        for (int b = 0; b < column; b++)
        {
            array[a, b] = Math.Round(rand.Next(startRange, endRange + 1) + rand.NextDouble(), 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            System.Console.Write(array[a, b] + "\t");
        }
        System.Console.WriteLine();
    }
}

Array();