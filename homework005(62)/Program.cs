// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void Main()
{
    Console.Clear();
    int[,] array = new int[4, 4];
    FillArray(array);
    PrintArray(array);
}
void FillArray(int[,] arr)
{
    int i = 0;
    int j = 0;
    int value = 1;

    for (int count = 0; count < (arr.GetLength(0) + arr.GetLength(1)) / 4; count++)

    {
        for (j = count; j < arr.GetLength(1) - count; j++)
        {
            arr[i, j] = value;
            value++;
        }
        j--;

        for (i++; i <= arr.GetLength(0) - count - 1; i++)
        {
            arr[i, j] = value;
            value++;
        }
        i--;
        for (j--; j >= count; j--)
        {
            arr[i, j] = value;
            value++;
        }
        j++;

        for (i--; i >= count + 1; i--)
        {
            arr[i, j] = value;
            value++;
        }
        i++;
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write($" 0{arr[i, j]}");
            }
            else
            {
                Console.Write($" {arr[i, j]}");
            }
        }
        Console.WriteLine();
    }
}
Main();