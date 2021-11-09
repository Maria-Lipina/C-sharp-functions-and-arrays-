void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

void Sorting(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // сделал код на одну строку меньше (сравни с PrintArray)
    {
        int minPosition = i; //позиция рабочего элемента, для которой мы будем производить действия

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; // чтобы поменять положение minPosition с той позицией, которую нашли при выполнении строчек выше
        array[i] = array[minPosition]; //чтобы поменять переменные местами. Положить в позицию i тот элемент, который нашли в строчках выше, а значит который удовлетворяет условию сортировки и должен отображаться в выходном массиве на данном месте
        array[minPosition] = temporary;
    } 
}

int[] arr = { 3, 6, 8, 0, 2, 4, 10, 3, 8, 7 };
PrintArray(arr);
Sorting(arr);
PrintArray(arr); 

