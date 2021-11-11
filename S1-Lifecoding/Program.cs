using static System.Console;
using static System.Convert;

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// int [] Fillarray(int N)
// {
//  int [] array = new int [N+1];

// for (int i = 1; i < array.Length; i++)
// {
//     array [i-1] = i*i;
// }
//  return array;   
// }

// void PrintArray(int[] collect)
// {
//     for (int pos = 0; pos < collect.Length; pos ++) Console.Write($"{collect[pos]} ");
//     Console.WriteLine();
//     Console.WriteLine();
// }

// PrintArray(Fillarray(5));

// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А

// int Sum (int A)
// {int sum = 0;
// for (int i = 1; i < A+1; i++)
// {
//     sum = sum + i;
// }
// return sum;
// }

// int Sum1 = Sum(10);
// Console.WriteLine(Sum1);

// 26. Возведите число А в натуральную степень B используя цикл

// int Power (int A, int B)
// {int result = A;
// for (int i =1; i < B; i++)
// {
//     result = result * A;
// }
// return result;
// }

// Console.WriteLine(Power(2,3));

// 27. Определить количество цифр в числе

// int Num = 12893;

// int DigitQuantity(int Num)
// {
// return Convert.ToString(Num).Length;
// }

// n         o
// 12345   
// 1234            5
// 123             4
// 12              3
// 1               2
// 0               1
int Counter(int n)
{
    int res  =0;
    int s=0;
    if (n == 0)
    {
    res  =1;
    s=1;
    }
    else
    {
    while(n!=0)
    {
        int o = n%10;
        s+=o;
        res++;
        n/=10;
    }
    }
    return s;
}
System.Console.WriteLine(Counter(0));
System.Console.WriteLine(Counter(10));
System.Console.WriteLine(Counter(23));
System.Console.WriteLine(Counter(110));
System.Console.WriteLine(Counter(11023));
// int DG = DigitQuantity(Num);

// 28. Подсчитать сумму цифр в числе

// string [] Fillarray(int Num)
// {
// string [] digits = new string [Convert.ToString(Num).Length];
// string digit = Convert.ToString(Num);
// for (int i = 0; i < digits.Length; i++)
// {
//     digits [i] = digit [0];
// }

//     return ;
// }

// void PrintArray(string[] collect)
// {
//     for (int pos = 0; pos < collect.Length; pos ++) Console.Write($"{collect[pos]} ");
//     Console.WriteLine();
//     Console.WriteLine();
// }

// PrintArray(digits);

// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру
