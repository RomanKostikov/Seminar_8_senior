// адача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

void Main()
{
    int[,] ourArray = new int[5, 5];
    //MaxNumber = 10;
    GetArray(ourArray);
    PrintArray(ourArray);
    GetStatistic(ourArray);

}


int[,] GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*int MaxNumber (int[,] arr)
{
    int max = 
}*/

void GetStatistic(int[,] arr)
{
    for (int i = 0; i < 10; i++)
    {
        int count = 0;
        foreach (int el in arr)
            if (el == i)
            {
                count++;

            }
        Console.WriteLine($" Число {i} встречается {count}");

    }
}

Main();
