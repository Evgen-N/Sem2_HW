// Task 41.
/*
int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

void Showarray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

int PositiveCount(int [] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) counter++;
    }
    return counter;
}

int [] EnterMNumbers(int numberOfNumbers)
{
    int [] array = new int[numberOfNumbers];
    
    for(int i = 0; i < numberOfNumbers; i++)
    {
        array[i] = Prompt("Enter an integer number: ");
    }
    return array;
}

int mNumbers = Prompt("Enter the number of numbers : ");

int [] mArray = EnterMNumbers(mNumbers);
int posNumbers = PositiveCount(mArray);
Showarray(mArray);
Console.WriteLine ($" -> {posNumbers}");
*/

// Task 43.
/*
double Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    double res = double.Parse(readInput);
    return res;
}

void Showarray (double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

double [] EnterParameters(int size, string [] arrayIn) 
{
    double [] arrayOut = new double[size];
    for(int i = 0; i < size; i++)
    {
        arrayOut[i] = Prompt($"Enter {arrayIn[i]}: ");
    }
    return arrayOut;
}

int size = 4;
string [] parameterNames = new string[size];
parameterNames[0] = "k1";
parameterNames[1] = "b1";
parameterNames[2] = "k2";
parameterNames[3] = "b2";

double [] parameterValues = EnterParameters(size, parameterNames);
double x0 = (parameterValues[3] - parameterValues[1]) / (parameterValues[0] - parameterValues[2]);
double y0 = parameterValues[0] * x0 + parameterValues[1];

//Showarray(parameterValues);
Console.WriteLine ();
Console.WriteLine ($"Intersection point is: ({x0}, {y0})");
*/