// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Введите значения b1 и k1 через запятую");
// double[] firstLine = Array.ConvertAll(Console.ReadLine().Split(','), double.Parse);
// Console.WriteLine("Введите значения b2 и k2 через запятую");
// double[] secondLine = Array.ConvertAll(Console.ReadLine().Split(','), double.Parse);
// double x = (secondLine[0] - firstLine[0])/(firstLine[1] - secondLine[1]);
// double y = secondLine[0]*x + secondLine[1];
// Console.WriteLine(x);
// Console.WriteLine(y);

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую");
double[] line = Array.ConvertAll(Console.ReadLine().Split(','), double.Parse);
int a = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] > 0)
    {
        a++;
    }
}
Console.WriteLine($"Количество чисел больше ноля = {a}");
