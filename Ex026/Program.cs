﻿// метод решения
static int Accerman(int n, int m)
{
    if (n == 0)

        return m + 1;

    else

        if ((n != 0) && (m == 0))
        return Accerman(n - 1, 1);
    else

        return Accerman(n-1, Accerman(n, m-1));

}


Console.WriteLine(Accerman(2, 3));