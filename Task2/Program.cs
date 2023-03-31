// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("input integer 'b1': ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input integer 'k1': ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input integer 'b2': ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input integer 'k2': ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
// Console.WriteLine($"intersection point is: y = {y}, x = {x}");
if(k1 == k2)
    Console.WriteLine("lines do not intersect");
else Console.WriteLine($"intersection point is: y = {y}, x = {x}");