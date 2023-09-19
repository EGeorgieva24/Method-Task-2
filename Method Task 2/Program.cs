using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input a name: ");
        string userName = Console.ReadLine();

        WelcomeFriend(userName);
    }
    static void WelcomeFriend(string name)
    {
        Console.WriteLine($"Welcome friend {name}!");
        Console.WriteLine("Have a nice day!");
    }
}
