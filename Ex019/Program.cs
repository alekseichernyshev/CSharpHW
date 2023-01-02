// метод создания массива
static int[,] CreateArray(int i, int j)
{
    return new int[i, j];
}

// метод заполнения массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

static void PrintArray(int[,] array)
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


Console.WriteLine("введите размеры массива");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int[,] arr = CreateArray(a, b);
FillArray(arr);
PrintArray(arr);
Console.WriteLine("введите индексы");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if(x >a && y > b)
{
    Console.WriteLine("такого числа не существует");
}
else{
    object c = arr.GetValue (x,y);
    Console.WriteLine(c); 
}