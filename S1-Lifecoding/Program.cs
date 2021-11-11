using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("9. Показать последнюю цифру трёхзначного числа"); //Счет цифр идет от единиц, а не высшего разряда, как здесь от сотен. От мин к макс

int number = 234;
string text = Convert.ToString(number);
Console.WriteLine(text [0]);

WriteLine();
WriteLine("10. Показать вторую цифру трёхзначного числа");

int number1 = 567;
string text1 = Convert.ToString(number1);
Console.WriteLine(text1 [1]);
