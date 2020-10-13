using System;

namespace President
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are the president!\nWhat is your name?");
            string name = Console.ReadLine();

            President newPresident = new President(name);

            newPresident.Present();

            Console.ReadLine();
        }
    }
}
