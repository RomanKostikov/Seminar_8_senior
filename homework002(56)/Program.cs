// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

void Main()
{
    Console.Clear();
    Console.Write("Enter the number of rows array: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the number of columns array: ");
    int columns = int.Parse(Console.ReadLine()!);
    int[,] array = GetArray(rows, columns);
    PrintArray(array);
    Console.WriteLine();
    GetSummAndFindMin(array);
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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
void GetSummAndFindMin(int[,] arr)
{
    int minSumm = 0;
    int summ = 0;
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];
        }
        if (i == 0)
        {
            minSumm = summ;
        }
        else if (summ < minSumm)
        {
            minSumm = summ;
            minRow = i;
        }
    }
    Console.WriteLine($"Number of the row with the smallest sum of elements: {minRow + 1}");
}
Main();