using System;

namespace President
{
    public class President
    {
        static Random generator = new Random();

        string name;

        int environmentPriority;

        int defensePriority;

        int healthcarePriority;

        int corruption;

        int money;

        public President(string n)
        {
            environmentPriority = generator.Next(0, 101);

            defensePriority = generator.Next(0, 101);

            healthcarePriority = generator.Next(0, 101);

            name = n;
        }

        public void Present()
        {
            Console.Clear();

            Console.WriteLine("Hello President " + name + "." +
            "\nEnviroment Priority is " + environmentPriority + "." +
            "\nDefense Priority is " + defensePriority + "." +
            "\nHealthcare Priority is " + healthcarePriority + ".");
        }

        // public bool PassLegislation(int e, int d, int h, int bribe)
        // {

        // }
    }
}
