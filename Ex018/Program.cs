
// метод создания массива
static double[,] CreateArray(int n, int m)
{
    return new double[n, m];
}

// метод заполнения массива
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/ 10.0);
        }
    }
}


// метод печати массива
static void PrintArray(double[,] array)
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


Console.WriteLine("введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine());

double[,] arr = CreateArray(m,n);
FillArray(arr);
Console.WriteLine();
PrintArray(arr);