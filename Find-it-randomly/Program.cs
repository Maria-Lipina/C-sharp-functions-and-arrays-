// Методы

void FillArray(int[] collection)
{
    int length = collection.Length; // определили размер массива collection
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 5);
        index++;
    }
}

void PrintArray(int[] collect) // collect и collection - разные аргументы, привыкайте называть их по-разному
{
    int count = collect.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collect[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // для сохранения индекса элемента, для которого if - истина. 0 здесь значило бы "первый элемент массива". Для чисел, которых НЕТ в массиве, это было бы некорректно. Поэтому значение по умолчанию дано как -1. В результате работы кода оно значит, что такого элемента нет в массиве. Традиционное изящное решение программистов.

    while (index < count)
    {
        if (collection[index] == find)
        {
        position = index;
        break; // без него программа покажет индекс *последнего* из вхождений нужного числа в массив. А так после первого нахождения алгоритм счастливо прерывается и показывает результат.
        }
    index++;
    }
    return position; // для методов(функций) с типом данных void оператор return НЕ нужен, так как они могут и не возвращать никакого значения 
}

// Cобственно цикл, для которого прописаны методы выше

int[] array = new int[10]; //определили (создали) новый массив, в котором по умолчанию 10 элементов. Пока нет void FillArray + PrintArray, в массиве одни нули.

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf (array, 7); // 4 - это значение элемента массива, для которого мы должны найти его индекс в этом же массиве
Console.WriteLine (pos);