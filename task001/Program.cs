// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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
    int rows2 = array.GetLength(0) - 1;
    int columns2 = array.GetLength(1) - 1;
    int[,] array2 = SwitchRows(array, rows2, columns2);
    PrintArray(array2);
    Console.WriteLine();
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

int[,] SwitchRows(int[,] arr, int rows1, int colmns1)
{
    int temp = 0;
    for (int j = 0; j < colmns1; j++)
    {
        temp = arr[0, j];
        arr[0, j] = arr[rows1, j];
        arr[rows1, j] = temp;

    }

    return arr;

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

Main();