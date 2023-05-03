/*
//Task 19.

void Palindrome5(int number)
{
    if (number / 10000 == number % 10 & number / 1000 % 10 == number % 100 / 10)
    {
        Console.WriteLine("Palindrome.");
    }
    else
    {
        Console.WriteLine("Not a Palindrome.");
    }
}

void Digit5Void()
{
    Console.WriteLine("Input 5-digits number: ");
    int user_number = Convert.ToInt32(Console.ReadLine());

    if (user_number / 10000 >= 1 & user_number / 10000 < 10)
    {
        Palindrome5(user_number);
    }
    else
    {
        Console.WriteLine("Impossible value!");
    }      
}

Digit5Void();
*/

/*
//Task 21.

double LongLine3D (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 -x2) + (y1 - y2)*(y1 -y2) + (z1 - z2)*(z1 -z2));
    return lengthAB;
}

Console.WriteLine ("Enter x of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter y of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter z of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Enter x of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter y of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter z of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = Math.Round(LongLine3D(xCoordA, yCoordA, zCoordA, xCoordB, yCoordB, zCoordB), 3);

Console.WriteLine ($"3D-Distance AB is {dist}");
*/

//Task 23 
/*
void CubeFinder ()
{
    Console.WriteLine ("Enter N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if (numberN > 0)
    {
        int current_i = 1;
        while (current_i <= numberN)
        {
            int res = current_i * current_i * current_i;
            Console.Write ($"{res}, ");
            current_i ++;
        }
        Console.WriteLine ("\b\b.");
    }
    else Console.WriteLine ("Impossible value!");
}

CubeFinder();
*/