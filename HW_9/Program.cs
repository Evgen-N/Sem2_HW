// Task 64.
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

int Numbers(int startNumber)
{
    if (startNumber == 1)
    {
        Console.Write($"{startNumber}");
        return 1;
    }
    else
    {
        Console.Write($"{startNumber}, ");
        startNumber--;
        return Numbers(startNumber);
    }
}

int n = Prompt("Input natural number N: ");
Numbers(n);
*/

// Task 66.
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

int Numbers(int startNumber, int endNumber)
{
    if (startNumber == endNumber) return endNumber;
    else return startNumber + Numbers(startNumber + 1, endNumber);
}

int m = Prompt("Input natural number M: ");
int n = Prompt("Input natural number N (!!! N > M): ");

Console.Write($"Sum of natural numbers from {m} to {n} is {Numbers(m, n)}");
*/

// Task 66.
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

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ack(n - 1, 1);
    else return Ack(n - 1, Ack(n, m - 1));
}

int n = Prompt("Input natural number n: ");
int m = Prompt("Input natural number m: ");

Console.Write($"Ackermann function for n = {n} and m = {m} is {Ack(n, m)}");
*/