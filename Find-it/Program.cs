//              0   1    2   3  4  5  6  7  8  9
int[] array = { 10, 23, 230, 4, 5, 6, 7, 8, 9, 10 };
int find = 230;
int n = array.Length;

int index = 0;

while (index < n)
{
if (array[index] == find)
{
 Console.WriteLine(index);
 break;
}
index++;
}

// Как сначала попыталась написать, но не сработало. Должно быть из-за правила index++, которое Голенищев объяснял на семинаре
// while (index < n)
// {
// if (array[index] != find)
// {
//  index++;
// }
// Console.WriteLine(index);
// break;
// }
