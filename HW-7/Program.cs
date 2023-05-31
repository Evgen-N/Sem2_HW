// Task 47.
/*
try {}
    catch (Exception e)
    {
    #pragma warning disable CA2200 
    #pragma warning disable CS8600
    #pragma warning disable CS8604
        throw e;
    }

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

double [,] Generate2DArray(int rows, int columns, int minValue, int maxValue)
{
    double [,] array= new double [rows, columns];
    Random random = new Random();
    for(int row = 0; row < rows; row++)
        for(int column = 0; column < columns; column++)
            array[row, column] = Math.Round(random.Next(minValue, maxValue) + new Random().NextDouble(), 2);
    return array;
}

void Show2Darray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]}, ");
            Console.Write("\b\b]");
            Console.WriteLine();
        }
}

int m = Prompt("Input count of rows: ");
int n = Prompt("Input count of columns: ");
int minValue = Prompt("Input min value: ");
int maxValue = Prompt("Input max value: ");

double [,] random2DArray = Generate2DArray(m, n, minValue, maxValue);
Show2Darray(random2DArray);
*/

// Task 50.
/*
try {}
    catch (Exception e)
    {
    #pragma warning disable CA2200 
    #pragma warning disable CS8600
    #pragma warning disable CS8604
        throw e;
    }

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

double [,] Generate2DArray(int rows, int columns, int minValue, int maxValue)
{
    double [,] array= new double [rows, columns];
    Random random = new Random();
    for(int row = 0; row < rows; row++)
        for(int column = 0; column < columns; column++)
            array[row, column] = Math.Round(random.Next(minValue, maxValue) + new Random().NextDouble(), 2);
    return array;
}

void Show2Darray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]}, ");
            Console.Write("\b\b]");
            Console.WriteLine();
        }
}

int m = Prompt("Input count of rows: ");
int n = Prompt("Input count of columns: ");
int minValue = Prompt("Input min value: ");
int maxValue = Prompt("Input max value: ");

double [,] random2DArray = Generate2DArray(m, n, minValue, maxValue);
Show2Darray(random2DArray);
Console.WriteLine();

int numRow = Prompt("Input value of row: ");
int numCol = Prompt("Input value of column: ");
if ((numRow >= m) || (numCol >= n)) Console.WriteLine("Invalid data!");
else Console.WriteLine($"array[{numRow}, {numCol}] = {random2DArray[numRow, numCol]}");
*/

// Task 52.
/*
try {}
    catch (Exception e)
    {
    #pragma warning disable CA2200 
    #pragma warning disable CS8600
    #pragma warning disable CS8604
        throw e;
    }

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

int [,] Generate2DArray(int m, int n, int minValue, int maxValue)
{
    int [,] array= new int[m, n];
    Random random = new Random();
    for(int i = 0; i < m; i++)
    {    
        for(int j = 0; j < n; j++)
            array[i, j] = random.Next(minValue, maxValue + 1);    
    }
    return array;
}

void Show2Darray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}, ");
            }
            Console.Write("\b\b]");
            Console.WriteLine();
        }
}

void Showarray (double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

double [] Mean2DColumn (int [,] array)
{
    double [] meanCol = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double temp = 0;
        for(int i = 0; i < array.GetLength(0); i++) 
            temp += array[i, j];
        meanCol[j] = Math.Round(temp / array.GetLength(0), 1);
    }    
    return meanCol;
}

int m = Prompt("Input count of rows: ");
int n = Prompt("Input count of columns: ");
int minValue = 0;
int maxValue = 9;

int [,] random2DArray = Generate2DArray(m, n, minValue, maxValue);
Show2Darray(random2DArray);
Console.WriteLine();

double [] meanColumn = Mean2DColumn(random2DArray);
Showarray(meanColumn);
*/