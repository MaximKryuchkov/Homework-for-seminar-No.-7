// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

System.Console.WriteLine("Двумерный массив: ");

void Array()
{
    int[,] matrix = FillMatrix(3, 4, 1, 10);
    PrintMatrix(matrix);
    double[] array = ArithmeticMean(matrix);
    PrintArray(array);
}

int[,] FillMatrix(int row, int column, int startRange, int endRange)
{
    int[,] array = new int[row, column];
    Random rand = new Random();
    for (int a = 0; a < row; a++)
    {
        for (int b = 0; b < column; b++)
        {
            array[a, b] = rand.Next(startRange, endRange + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
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

double[] ArithmeticMean(int[,] array)
{
    double[] answer = new double[array.GetLength(1)];
    for (int b = 0; b < array.GetLength(1); b++)
    {
        for (int a = 0; a < array.GetLength(0); a++)
        {
            answer[b] += array[a, b];
        }
        answer[b] /= array.GetLength(0);;
    }
    return answer;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine($"Cреднее арифметическое элементов в каждом столбце =  {string.Join("; ", array)}");
}

Array();