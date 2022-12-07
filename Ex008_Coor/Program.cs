// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Пожалуйста, введите первое значение первой точки Enter\t");
Double xa = Double.Parse(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите второе значение первой точки Enter\t");
Double ya = Double.Parse(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите первое значение второй точки Enter\t");
Double xb = Double.Parse(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите второе значение второй точки Enter\t");
Double yb = Double.Parse(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)));