/*
//Task 10.

void Digit2Void(int number)
{
    int n10 = number / 10 % 10;
    Console.WriteLine($"The second digit is: {n10}");
}

Console.WriteLine("Input 3-digits number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 99 & user_number < 1000)
{
    Digit2Void(user_number);
}
else
{
    Console.WriteLine("Impossible value!");
}
*/

/*
//Task 13.

void Digit3Void()
{
    Console.WriteLine("Input your integer number: ");
    int user_number = Convert.ToInt32(Console.ReadLine());

    if (user_number < 0) user_number = - user_number;
    if (user_number > 99)
    {
        while (user_number >= 1000) user_number = user_number / 10;
        int n100 = user_number % 10;
        Console.WriteLine($"The third digit is: {n100}");
    }
    else
    {
        Console.WriteLine("There is no third digit!");
    }
}
Digit3Void();
*/

/*
//Task 15.

void Digit7Void()
{
    Console.WriteLine("Input your day number: ");
    int user_number = Convert.ToInt32(Console.ReadLine());

    if (user_number < 1 || user_number > 7) Console.WriteLine("This is not a day number!");
    else
    {
        if (user_number == 6 || user_number == 7)
        {
            Console.WriteLine("It's a day off");
        }
        else
        {
            Console.WriteLine("This day is not a day off");
        }
    }
    
}
Digit7Void();
*/