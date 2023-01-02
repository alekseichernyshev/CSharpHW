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
            array[i, j] = new Random().Next(0,10);
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
int[,] arr = CreateArray(m, n);
FillArray(arr);
PrintArray(arr);
Console.WriteLine();

for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        sum += arr[i, j];
    }
    Console.WriteLine(sum/ arr.GetLength(1));
}
    



