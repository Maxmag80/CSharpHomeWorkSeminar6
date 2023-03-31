// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
//Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему -
//площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным,
//равнобедренным, равносторонним.
Console.WriteLine("input first integer number n1: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input second integer number n2: ");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input third integer number n3: ");
double n3 = Convert.ToDouble(Console.ReadLine());

if(n1+n2>n3 && n1+n3>n2 && n2+n3>n1)
{
    Console.WriteLine("its a correct sides of triangle");

//S = √p(p - a)(p - b)(p - c)   , где p=​​1/2​​⋅(a+b+c)- полупериметр треугольника; a,b,c - стороны треугольника. 

    double p = (n1 + n2 + n3) / 2;
    double S = Math.Round(Math.Sqrt(p * (p - n1) * (p - n2) * (p - n3)), 3);
    Console.WriteLine($"the square of triangle is: {S}");
    double P = n1 + n2 + n3;
    Console.WriteLine($"the perimeter of triangle is: {P}");
// теорема косинусов Формула теоремы косинусов: a2 = b2 + c2 - 2bc cos α, cos a = (b2+c2-a2)/2bc
    double angle1 = Math.Round(Math.Acos((n2*n2 + n3*n3 - n1*n1) / (2 * n2 * n3)) * 180 / Math.PI, 2);
    double angle2 = Math.Round(Math.Acos((n1*n1 + n3*n3 - n2*n2) / (2 * n1 * n3)) * 180 / Math.PI, 2);
    double angle3 = 180 - angle1 - angle2;
    Console.WriteLine($"the angles of triangle is:  {angle1} ; {angle2} ; {angle3} .");

    if(angle1 == 90 || angle2 == 90 || angle3 == 90)
    {
        Console.WriteLine($"it's right-sided triangle");
    }
    bool equi = false;
    if(n1 == n2 && n2 == n3)
    {
        Console.WriteLine("it's an equilateral triangle");
        equi = true;
    }
    if(n1 == n2 || n1 == n3 || n2 == n3)
    {
        if(equi == false)
            Console.WriteLine("it is an isosceles triangle");
    }
}
else Console.WriteLine("its a not correct sides of triangle");