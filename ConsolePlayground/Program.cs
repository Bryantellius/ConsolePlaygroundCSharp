using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;

namespace ConsolePlayground
{
    class Program
    {
        class Hobbit: IPlayer
        {
            public string name;
            public Hobbit(string nm)
            {
                name = nm;
            }
            public string getName() { return name; }
            public void Greeting()
            {
                Console.WriteLine("I am " + name.ToUpper() + " from the SHIRE");
            }
        }

        class Wizard: IPlayer
        {
            public string name;
            public Wizard(string nm)
            {
                name = nm;
            }
            public string getName() { return name; }
            public void Greeting()
            {
                Console.WriteLine("I am " + name.ToUpper() + " and I am accompanying my dear friend.");
            }
        }

        interface IPlayer
        {
            void Greeting();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            Hobbit playerOne = new Hobbit(Console.ReadLine());
            playerOne.Greeting();
            Console.WriteLine("Hmm, that is a good name for a hero... Say it with pride. Be bold. Never stray from the path of wisdom and courage.");
            Console.WriteLine("And who might you be?");
            Wizard playerCompanion = new Wizard(Console.ReadLine());
            playerCompanion.Greeting();
            Console.WriteLine("Ahh, you look to be very wise. " + playerOne.getName() + " must be grateful to have your help. Let the journey BEGIN!");
        }
    }
}
