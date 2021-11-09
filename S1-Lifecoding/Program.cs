using static System.Console;

// Почувствуй себя интерном (семинар 04.11.2021)
WriteLine("0. Вывести квадрат числа");

int x = 4;
int power = x*x;
WriteLine(power);


WriteLine("1. По двум заданным числам проверять является ли первое квадратом второго");

bool IsQuadrat (int x1, int x2)
{
int z = x2*x2;
if (z==x1) return true;
else return false; 
}

WriteLine(IsQuadrat(25, 5));

WriteLine("2. Даны два числа. Показать большее и меньшее число");

void CompareNum (int x, int y)
{
if (y>x) Console.WriteLine(y + " больше " + x);
else Console.WriteLine(x +" больше "+ y);
}

CompareNum(25, 5);


WriteLine("3. По заданному номеру дня недели вывести его название");

//int[] day = new int[] {1, 2, 3, 4, 5, 6, 7};

int day = 2;

string name = day switch
{
1 => "понедельник",
2 => "вторник",
3 => "среда",
4 => "четверг",
5 => "пятница",
6 => "суббота",
7 => "воскресенье",
_ => "нет дня недели с таким номером"
};


WriteLine("4. Найти максимальное из 3 чисел");

// int number1 = 8;
// int number2 = 2;
// int number3 = 15;

// int max = number1;
// if (number2 > max) max = number2;
// if (number3 > max) max = number3;
// Console.WriteLine(max);

WriteLine(power); //  5. Написать программу вычисления значения функции y=f(a)

// int f(int a)
// {
//     //предположим, функция f=a^3 - это было неправильно, надо было уточнять у Сергея
//     return a*a*a;
// }
// int y1 = f(2);
// Console.WriteLine(y1);

WriteLine(power);// //  6. Выяснить является ли число чётным

// int с = 3;

// if (с%2==0){Console.WriteLine("четное");}
// else {Console.WriteLine("нечетное");}

WriteLine(power);// //  7. Показать числа от -N до N

// int N = 5;

// for (int i = -N; i<= N; i++)
// {
//     Console.WriteLine(i);
// }

WriteLine(power);// //  8. Показать четные числа от 1 до N

// int n = 10;

// for (int i = 0; i<= n; i++)
// {
//     if (i%2==0)
//     {
//     Console.WriteLine(i);
//     }
// }

WriteLine(power);// //  9. Показать последнюю цифру трёхзначного числа

// int number = 234;
// string text = Convert.ToString(number);
// Console.WriteLine(text [2]);

WriteLine(power);// // 10. Показать вторую цифру трёхзначного числа

// int num = 234;
// string t = Convert.ToString(num);
// Console.WriteLine(t [1]);

WriteLine(power);// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int number4 = new Random().Next(10,99);
// Console.WriteLine (number4);

// int ten = number4 / 10;
// Console.WriteLine (ten);

// string preunit = Convert.ToString(number4);
// char preunit1 = 'preunit[1]';
// int unit = Convert.ToInt16(preunit1);
// Console.WriteLine (unit);

// if (ten > unit) Console.WriteLine (ten);
// else {Console.WriteLine (unit);}

WriteLine(power);// -----------------------------------------------Семинар 08.11.2021

WriteLine(power);// 12. Удалить вторую цифру трёхзначного числа

// int number5 = 465;
// string totext = Convert.ToString(number5);
// Console.Write($"{totext [0]}{totext [2]}");

WriteLine(power);// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// int number6 = 323;
// int crat = 10;

// if (number6 % crat == 0) Console.WriteLine ("Кратно");
// else {Console.WriteLine (number6 % crat);}

WriteLine(power);// 14. Найти третью цифру числа или сообщить, что её нет


WriteLine(power);// -----------------------------------------------

// Почувствуй себя джуном (Задачи, которые появились на самом семинаре 08.11.2021)
WriteLine(power);// 15. Дано число. Проверить кратно ли оно 7 и 23

// int number6 = 25;

// if (number6 % 7 == 0 || number6 % 23 == 0) Console.WriteLine ("Кратно");
// else {Console.WriteLine (" Не кратно");}

WriteLine(power);// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

// string WeekMethod(int arg)
// {
// if (arg==6 || arg ==7) 

// return "выходной";

// else return "будний день";
// }

// Console.WriteLine(WeekMethod(3));

WriteLine(power);// 17. По двум заданным числам проверять является ли одно квадратом другого

// string IsQuadrat(int arg1, int arg2)
// {
// if (arg1*arg2 % arg2 ==0) 

// return "Является";

// else return "Не является";
// }

// Console.WriteLine(IsQuadrat(64, 8));

WriteLine(power);// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool logic(bool x, bool y)
// {
//     return !(x || y) == !x && !y;
// }

// Console.WriteLine(logic(true, true));

WriteLine(power);// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// int x = 1;
// int y = -1;

// if (x > 0 && y > 0) Console.WriteLine(1);
// if (x > 0 && y < 0) Console.WriteLine(4);
// if (x < 0 && y < 0) Console.WriteLine(3);
// if (x < 0 && y > 0) Console.WriteLine3(3);


WriteLine(power);// 20. Задать номер четверти, показать диапазоны для возможных координат

WriteLine(power);// 21. Программа проверяет пятизначное число на палиндромом.
WriteLine(power);// 22. Найти расстояние между точками в пространстве 2D/3D
