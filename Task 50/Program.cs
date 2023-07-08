// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

System.Console.WriteLine("Двумерный массив: ");

void Array()
{
    int[,] array = FillArray(3, 4, 1, 10);
    PrintArray(array);
    FindingValue(array);
}


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillArray(int column, int row, int startRange, int endRange)
{
    int[,] array = new int[column, row];
    Random rand = new Random();
    for (int a = 0; a < column; a++)
    {
        for (int b = 0; b < row; b++)
        {
            array[a, b] = rand.Next(startRange, endRange + 1);
        }
    }
    return array;
}


void PrintArray(int[,] array)
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


void FindingValue(int[,] array)
{
    int row = ReadInt("Задайте номер строки: ");
    int column = ReadInt("Задайте номер столбца: ");
    if (row <= array.GetLength(0) && column <= array.GetLength(1))
    {
        System.Console.WriteLine($"Значение элемента = {array[column, row]}");
    }
    else
    {
        System.Console.WriteLine($"Заданный элемент отсутствует.");
    }
}


Array();