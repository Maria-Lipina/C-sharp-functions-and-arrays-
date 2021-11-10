using static System.Console;

WriteLine();
WriteLine("3. По заданному номеру дня недели вывести его название");

int day = Convert.ToInt32(ReadLine());

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
WriteLine(name);