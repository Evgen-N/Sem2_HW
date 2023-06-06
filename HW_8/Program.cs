// Task 54.
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

void Showarray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

int[] SortArray(int[] array, int leftIndex, int rightIndex)
{
    var i = leftIndex;
    var j = rightIndex;
    var pivot = array[leftIndex];
    while (i <= j)
    {
        while (array[i] < pivot)
        {
            i++;
        }
        
        while (array[j] > pivot)
        {
            j--;
        }
        if (i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    
    if (leftIndex < j)
        SortArray(array, leftIndex, j);
    if (i < rightIndex)
        SortArray(array, i, rightIndex);
    return array;
}

int [,] SortRows (int [,] array)
{
    int [,] sortedArray = new int[array.GetLength(0), array.GetLength(1)];
    int [] tempRow = new int[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
            tempRow[j] = array[i, j];
        tempRow = SortArray(tempRow, 0, array.GetLength(1) - 1);
        for(int j = 0; j < array.GetLength(1); j++)
            sortedArray[i, j] = tempRow[j];
    }    
    return sortedArray;
}

int m = Prompt("Input count of rows: ");
int n = Prompt("Input count of columns: ");
int minValue = 0;
int maxValue = 9;

int [,] random2DArray = Generate2DArray(m, n, minValue, maxValue);
Show2Darray(random2DArray);
Console.WriteLine();

int [,] sortedArray = SortRows(random2DArray);
Show2Darray(sortedArray);
*/

// Task 56.
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

void MinSumRow (int [,] array)
{
    int [] sumRow = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for(int j = 0; j < array.GetLength(1); j++) 
            tempSum += array[i, j];
        sumRow[i] = tempSum;
    }
    Console.WriteLine($"The row with min summ of elements has index {Array.IndexOf(sumRow, sumRow.Min())}");
}

int m = Prompt("Input count of rows: ");
int n = Prompt("Input count of columns: ");
int minValue = 0;
int maxValue = 9;

int [,] random2DArray = Generate2DArray(m, n, minValue, maxValue);
Show2Darray(random2DArray);
Console.WriteLine();

MinSumRow(random2DArray);
*/

// Task 58.
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

int [,] MatrixMulti (int [,] array1, int [,] array2)
{
    int [,] matrixMulti = new int[array1.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            int tempSum = 0;
            for(int k = 0; k < array1.GetLength(1); k++) 
                tempSum += array1[i, k] * array2[k, j]; 
            matrixMulti[i, j] = tempSum;
        }
    }
    return matrixMulti;
}

int m = Prompt("Input count of rows: ");
int n = Prompt("Input count of columns: ");
int minValue = 0;
int maxValue = 9;

int [,] random2DArray1 = Generate2DArray(m, n, minValue, maxValue);
Show2Darray(random2DArray1);
Console.WriteLine();

m = Prompt("Input count of rows: ");
n = Prompt("Input count of columns: ");
int [,] random2DArray2 = Generate2DArray(m, n, minValue, maxValue);
Show2Darray(random2DArray2);
Console.WriteLine();

int [,] random2DArray3 = MatrixMulti(random2DArray1, random2DArray2);
Show2Darray(random2DArray3);
*/

// Task 60.
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

int [,,] Generate3DArray(int m, int n, int p, int minValue, int maxValue)
{
    int [,,] array= new int[m, n, p];
    int [] values = new int[1];
    int temp = 0;
    Random random = new Random();
    for(int i = 0; i < m; i++)
    {    
        for(int j = 0; j < n; j++)
            for(int k = 0; k < p; k++)
            {
                while(values.Contains(temp) == true)
                    temp = random.Next(minValue, maxValue + 1);
                values = values.Concat(new int[] { temp }).ToArray();
                array[i, j, k] = random.Next(minValue, maxValue + 1);
            }    
    }
    return array;
}

void Show3Darray (int [,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            //Console.Write("[");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.Write("\b\b");
            Console.WriteLine();
        }
}

Console.WriteLine("!!! size1 * size2 * size3 < 100");
int m = Prompt("Input size1: ");
int n = Prompt("Input size2: ");
int p = Prompt("Input size3: ");
int minValue = 10;
int maxValue = 99;

int [,,] random3DArray = Generate3DArray(m, n, p, minValue, maxValue);
Show3Darray(random3DArray);
*/

// Task 62.
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

int [,] SpiralMatrix (int n, int m)
{
    int [,] matrix = new int[n, m];
    // Переменная, считающая числа
    int digit = 1;
    // Счетчик полных кругов по спирали
    int ch = 0;
    // В цикле заполняем по порядку: верхняя строка, правый крайний столбец, нижняя строка, левый крайний столбец и т.д.
    for(int r = 0; r < n + m; r++)
    {
        if(r % 4 == 0)
        {
            for(int c = ch; c < m - ch; c++)
            {
                matrix[ch, c] = digit;
                digit += 1;
            }
        }
        else if(r % 4 == 1)
        {
            for(int c = ch + 1; c < n - ch; c++)
            {
                matrix[c, m - ch -1] = digit;
                digit += 1;
            }
        }
        else if(r % 4 == 2)
        {
            for(int c = m - ch - 2; c > ch - 1; c--)
            {
                matrix[n - 1 - ch, c] = digit;
                digit += 1;
            }
        }
        else if(r % 4 == 3)
        {
            for(int c = n - ch - 2; c > ch; c--)
            {
                matrix[c, ch] = digit;
                digit += 1;
            }
            ch += 1;
        }
        if(digit > m * n) break;
    }
    return matrix;
}

int n = Prompt("Input count of rows: ");
int m = Prompt("Input count of columns: ");

int [,] spiralArray = SpiralMatrix(n, m);
Show2Darray(spiralArray);
*/