//Квадратное уравнение общего вида: ax^2+bx+c=0
//Методы:

double OneSolution (double a, double b, double c)
{
    double D = b*b - a*c*4;
    double x = (-b + Math.Sqrt(D)) / 2*a;
    return x;
}

double TwoSolutions (double a, double b, double c)
{
    double D = b*b - a*c*4;
    double x1 = (-b + Math.Sqrt(D)) / 2*a;
    Console.WriteLine (x1);
    double x2 = (-b - Math.Sqrt(D)) / 2*a;
    return x2;
}

// Собственно программа

Console.WriteLine("Для решения квадратного уравнения введите коэффициенты");

Console.Write("a = ");
double a1 = double.Parse(Console.ReadLine());

if (a1 == 0) 
{
    Console.WriteLine ("Недопустимое значение a");
    Environment.Exit(1);
// как здесь прописать "компьютер, верни пользователя обратно к введению а1"?
}

Console.Write("b = ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("c = ");
double c1 = double.Parse(Console.ReadLine());

double D1 = b1*b1 - a1*c1*4;

if (D1 < 0)
{
    Console.WriteLine ("Нет корней");
}
if (D1 == 0)
{
    double result = OneSolution(a1, b1, c1);
    Console.WriteLine (result);
}
if (D1 > 0)
{
    double result = TwoSolutions (a1, b1, c1);
    Console.WriteLine (result);
}

