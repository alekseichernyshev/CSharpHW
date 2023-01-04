// метод суммирования элементов
static int SumElements(int m, int n)
{
    int result = m;
    for (int i = m+1; i <= n; i++)
    {
        result += i;
    }
    return result;
}
Console.WriteLine(SumElements(10, 14));
