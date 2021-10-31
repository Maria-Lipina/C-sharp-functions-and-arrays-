int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 1000;
int a2 = 700;
int a3 = -3;

int b1 = 5;
int b2 = 30;
int b3 = 89098;

int c1 = 29;
int c2 = 0;
int c3 = 3333;

//int max1 = Max(a1, a2, a3);
//int max2 = Max(b1, b2, b3);
//int max3 = Max(c1, c2, c3);

int MaxFin = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(MaxFin);