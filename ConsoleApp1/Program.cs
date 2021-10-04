using ConsoleApp1.MakeThisWork;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            TheApp();
        }

        public static void TheApp()
        {
            Console.WriteLine("Which application do you want to use? Pick a number and confirm with an Enter.");
            Console.WriteLine("[1] Dictionary app");
            Console.WriteLine("[2] Car app");

            var result = Int32.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine("Use 'Spacebar' key to display records.");
                    Logic dictApp = new Logic();
                    dictApp.DictionaryApp();
                    StartAgain();
                    break;
                case 2:
                    Logic carApp = new Logic();
                    carApp.CarApp();
                    StartAgain();
                    break;
            }
        }

        public static void StartAgain()
        {
            Console.WriteLine("Enter to start again.");
            var keyInfo = Console.ReadKey();
            if(keyInfo.Key.Equals(ConsoleKey.Enter))
            {
                Console.Clear();
                TheApp();
            }
        }
    }
}
