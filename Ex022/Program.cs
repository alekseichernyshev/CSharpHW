// метод создания массива
static int[,] CreateArray(int m, int n)
{
    return new int[m,n];
}

// метод заполнения массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,9);
        }
    }
}

//метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

//метод суммирования строки
int SumLineElements(int[,] array, int i)
{
    int sumLine = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
}


Console.WriteLine("введите количество строк и столбцов в массиве");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] arr = CreateArray(m,n);
FillArray(arr);
Console.WriteLine("массив");
PrintArray(arr);
Console.WriteLine();
int minSumLine = 0;
int sumLine = SumLineElements(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
    int temp = SumLineElements(arr, i);
    if(sumLine>temp)
    {
        sumLine = temp;
        minSumLine = i;
    }
}
Console.WriteLine($"{minSumLine + 1} - строка с наименьшей суммой ({sumLine}) элементов");
