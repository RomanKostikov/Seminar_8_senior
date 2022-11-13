//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// /Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//задача на приминение пузырькового метода сортировки

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

    int[,] newArray = BubbleSort(array);
    PrintArray(newArray);

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

int[,] BubbleSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int count = 0; count < arr.GetLength(1); count++)
        {

            int temp = 0;


            for (int j = 1; j < arr.GetLength(1) - count; j++)
            {
                if (arr[i, j - 1] < arr[i, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j - 1];
                    arr[i, j - 1] = temp;
                }


            }


        }
    }
    return arr;

}

Main();