
// See https://aka.ms/new-console-template for more information


double a;
double b;
double c;

Console.WriteLine("Квадратичная функция - y= ax^2 + bx + c");
Console.WriteLine("выведите число a");
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());

double x0 = -b / (2 * a);
Console.WriteLine($"x0 = {x0}");
double y0 = a * Math.Pow(x0, 2) + b * x0 + c;
Console.WriteLine($"y0 = {y0}");
double n = Math.Pow(b, 2) - 4 * a * c;

Console.WriteLine("");

if(a > 0)
{

    Console.WriteLine("ветви направлены вверх");
}

else if (a < 0)
{
    Console.WriteLine(" ветви направлены вниз");
}

if(a > 0 )
{
    Console.WriteLine($"min znach: {y0}");
}

else if (a < 0)
{
    Console.WriteLine($"max znach:{y0}");
}

if (a > 0)
{
    Console.WriteLine($" убывает от -inf: {-x0}; возрастает от {-x0}: inf ");
}

if (n <= 0)
{
    Console.WriteLine($"{a > 0} функц всегда + ");
}

else if (n <= 0)
{
    Console.WriteLine($"{a < 0} функц всегда - ");
}

double x1 = -b + Math.Sqrt(n) / 2 * a;
double x2 = b - Math.Sqrt(n) / 2 * a;

if (n >= 0)
{
    Console.WriteLine(x1);
    Console.WriteLine(x2);
}