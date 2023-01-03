// метод создания массива

static int[,] CreateArray(int m, int n)
{
    return new int[m, n];
}

// метод заполнения массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

// метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите размер массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] arr = CreateArray(m, n);
FillArray(arr);
Console.WriteLine("изначальный массив");
PrintArray(arr);
int temp;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {


            if (arr[i, k] < arr[i, k + 1])
            {
                temp = arr[i, k];
                arr[i, k] = arr[i, k + 1];
                arr[i, k + 1] = temp;
            }
        }
    }
}




Console.WriteLine("отсортированный массив");
PrintArray(arr);