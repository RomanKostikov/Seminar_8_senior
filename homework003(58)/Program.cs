// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, 
// там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void Main()
{
    Console.Clear();
    Console.Write("Enter the number of rows first array: ");
    int rows1 = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the number of columns first array: ");
    int columns1 = int.Parse(Console.ReadLine()!);
    int[,] firstArray = GetArray(rows1, columns1);

    Console.Write("Enter the number of rows second array: ");
    int rows2 = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the number of columns second array: ");
    int columns2 = int.Parse(Console.ReadLine()!);
    int[,] secondArray = GetArray(rows2, columns2);

    Console.WriteLine("First array:");
    PrintArray(firstArray);
    Console.WriteLine("*");
    Console.WriteLine("Second array:");
    PrintArray(secondArray);
    Console.WriteLine("=");

    MultiplyArrays(firstArray, secondArray);
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
void MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int[,] resultArr = new int[arr1.GetLength(0), arr2.GetLength(1)];

    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    resultArr[i, j] += (arr1[i, k] * arr2[k, j]); // правило умножения матриц
                }
            }
        }
        PrintArray(resultArr);
    }
    else
    {
        Console.WriteLine("You can multiply two matrices only if the number of columns of the first is equal to the number of rows of the second.");
        Console.WriteLine("Resize the matrix and try again");
    }
}
Main();