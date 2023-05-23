// Task 34.
/*
int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int [] array= new int[Length];
    Random random = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void Showarray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

int EvenCount(int [] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 = 0) counter++;
    }
    return counter;
}

int Length = Prompt("Введите длину массива: ");
int minValue = 100;
int maxValue = 999;

int [] randomArray = GenerateArray(Length, minValue, maxValue);
int evens = EvenCount(randomArray);
Showarray(randomArray);
Console.WriteLine ($" -> {evens}");
*/

// Task 36.
/*
int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int [] array= new int[Length];
    Random random = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void Showarray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

int OddIndexSum(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i += 2) sum += array[i];
    return sum;
}

int Length = Prompt("Введите длину массива: ");
int minValue = -99;
int maxValue = 99;

int [] randomArray = GenerateArray(Length, minValue, maxValue);
int oddsum = OddIndexSum(randomArray);
Showarray(randomArray);
Console.WriteLine ($" -> {oddsum}");
*/

// Task 38.
/*
int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

double [] GenerateArray(int Length)
{
    double [] array= new double[Length];
    Random random = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100, 2);
    }
    return array;
}

void Showarray (double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

int Length = Prompt("Введите длину массива: ");

double [] randomArray = GenerateArray(Length);
double res = randomArray.Max() - randomArray.Min();
Showarray(randomArray);
Console.WriteLine ($" -> {res}");
*/