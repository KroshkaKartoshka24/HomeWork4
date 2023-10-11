// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значения b1 и k1 через запятую");
double[] firstLine = Array.ConvertAll(Console.ReadLine().Split(','), double.Parse);
Console.WriteLine("Введите значения b2 и k2 через запятую");
double[] secondLine = Array.ConvertAll(Console.ReadLine().Split(','), double.Parse);
double x = (secondLine[0] - firstLine[0])/(firstLine[1] - secondLine[1]);
double y = secondLine[0]*x + secondLine[1];
Console.WriteLine(x);
Console.WriteLine(y);

