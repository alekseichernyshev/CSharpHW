
// метод печати
void PrintNumbers(int n)
{
    for (int i = n; i > 0; i--)
    {
        Console.Write($"{n} ");
        n--;
    }
    return;


}

PrintNumbers(8);