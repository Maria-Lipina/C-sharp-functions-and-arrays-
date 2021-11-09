// Задача 1
// Подсчитать количество натуральных (uint) чисел, не превосходящих заданного числа n, которые

// делятся на k, но не на l
// делятся хотябы на k или на l
// не делятся на (k + l)

// Методы

uint n = 100;
uint k = 4;
uint l = 10;
uint countif = 0; // потому что задание подсчитать числа, удовлетворяющие обоим условиям

for (int i = 1; i <= n; i++) // Потому что натуральные
{
    bool kCheck = (i % k) == 0;
    bool lCheck = (i % l) != 0;

    if (kCheck && lCheck) // конъюнкция, логическое И
    {
    Console.Write($"{i} "); 
    countif++;
    }
}
Console.WriteLine();
Console.WriteLine($"count = {countif}");

// Программа