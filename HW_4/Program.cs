// Task 25.
/*
int APowerB (int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
        res = res * a;
    return res;
}

Console.WriteLine ("Enter int A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter natural number B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"{num1} ** {num2} = {APowerB(num1, num2)}");
*/

// Task 27.
/*
void SumOfDigits (int numb)
{
    int part = numb;
    int sum = 0;
    while (part > 0)
    {
        sum = sum + part % 10;
        part = part / 10;
    }
    Console.WriteLine ($"Sum of digits in number {numb} is {sum}");
}

Console.WriteLine ("Enter natural number: ");
int numb = Convert.ToInt32(Console.ReadLine());

SumOfDigits(numb);
*/

// Task 29.
/*
int [] NewArray (int size, int min, int max)
{
    int [] arrayname = new int[size];
    for (int i = 0; i < size; i++)
        arrayname[i] = new Random().Next(min, max+1);
    return arrayname;
}

void Showarray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

int countOfEl = 8;
int minVal = 0;
int maxVal = 99;

int [] array1 = NewArray(countOfEl, minVal, maxVal);
Showarray(array1);
*/