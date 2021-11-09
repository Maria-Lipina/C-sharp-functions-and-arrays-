// Сформировать случайным образом N-элементный массив, заполненный однозначными целыми числами разных знаков. Задать k и выяснить

// сколько раз повторяется k в массиве
// сколько элементов находится между первым и последним k

// Функция1 для генерации массива

void FillArray (int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
{
    collection[index] = new Random().Next(-9, 10);
}
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{collection[position]} ");
        position++;
    }
}

// Функция 2 для того, чтобы задать К

int GetNumber()
{
Console.Write("Введите число для его поиска в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

// Функция 3 для того, чтобы посчитать повторения к в массиве

int Count(int[] collection, int find)
{
    int position = 0; // для сохранения индекса элемента, для которого if - истина. 0 здесь значило бы "первый элемент массива". Для чисел, которых НЕТ в массиве, это было бы некорректно. Поэтому значение по умолчанию дано как -1. В результате работы кода оно значит, что такого элемента нет в массиве. Традиционное изящное решение программистов.

    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] == find) position++;
    }
return position;
}

// Функция 4 для того, чтобы посчитать элементы между первым и последним к в массиве

int CountBetween (int[] collection, int find)
{
int firstpos = -100;
int lastpos = -100;
for (int i = 0; i < collection.Length; i++)
{
    if (collection[i] == find)
    {
    firstpos = i;
    break;
    }
}
for (int i = 0; i < collection.Length; i++)
{
   if (collection[i] == find)
   {
   lastpos = i;
   } 
}
int result = lastpos - firstpos - 1;
return result;
}

// А теперь составим итоговую програмку, оставив все функции наверху

int[] array = new int [15];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int k = GetNumber();

int quantity = Count(array, k);
Console.WriteLine(quantity);

int between = CountBetween(array, k);
Console.WriteLine(between);

//-------------------------------------------------------------------------------------------------

// Dev 1
// Задача
// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. Создать на его основе масив B, отбрасывая те, которые

// нарушают порядок возрастания
// больше среднего арифметического элементов A
// чётные

// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные
 

// Задать массив


int index = 0;

int[] arr = new int[10]; // переименовала переменную в копипасте из репозитория Сергея
// Заполняет массив
while (index < 10)
{
    arr[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив

while (index <= 9)
{
    int val = arr[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
index = 1;
// Исключение элементов нарушения возрастания
int currentElement = arr[0];
Console.WriteLine(currentElement);
while (index <= 9)
{
    if(array[index]>currentElement)
    {
        Console.WriteLine(arr[index]);
        currentElement = arr[index];
    }
    index++;
}

//----------------------------------------------------------------------------------------------

//Dev2
// Задача
// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, которые нарушают порядок

// возрастания
// элементы, больше 8
// знакочередования

// есть массив заполненный числами
// нужно создать второй массив, в который попадают числа из первого , но только те, которые не нарушают порядок возрастания 


// есть массив заполненный числами
// нужно создать второй массив, в который попадают числа из первого , но только те, которые чётные


// есть массив заполненный числами
// нужно создать второй массив, в который попадают числа из первого , но только те, которые больше среднего арифметического