using static System.Console;

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
    WriteLine (x1);
    double x2 = (-b - Math.Sqrt(D)) / 2*a;
    return x2;
}

// Собственно программа

WriteLine("Для решения уравнения ax^2+bx+c=0 введите коэффициенты");

Write("a = ");
double a1 = Convert.ToDouble(ReadLine());

if (a1 == 0) 
{
    WriteLine ("Недопустимое значение a");
    Environment.Exit(1);
// как здесь прописать "компьютер, верни пользователя обратно к введению а1"?
}

Write("b = ");
double b1 = Convert.ToDouble(ReadLine());

Write("c = ");
double c1 = Convert.ToDouble(ReadLine());

double D1 = b1*b1 - a1*c1*4;

if (D1 < 0)
{
    WriteLine ("Нет корней");
}
if (D1 == 0)
{
    Write ("Корни уравнения: ");
    double result = OneSolution(a1, b1, c1);
    WriteLine (result);
}
if (D1 > 0)
{
    Write ("Корни уравнения: ");
    double result = TwoSolutions (a1, b1, c1);
    WriteLine (result);
}

