using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tworzymy zwierze lądowe - żółwia - tortoise");
            //Animal -> LandAnimal -> Tortoise
            var tortoise = new Tortoise(GetNumberFromConsole("Podaj wzrost zółwia: "), GetNumberFromConsole("Podaj wagę żółwia: "));
            tortoise.PrintData();
            tortoise.Walk();
            tortoise.GenerateSound();

            Console.WriteLine("Tworzymy zwierze wodne - żółw wodny - turtle");
            var turtle = new Turtle(GetNumberFromConsole("Podaj wzrost zółwia wodnego: "), GetNumberFromConsole("Podaj wagę żółwia wodnego: "));
            turtle.PrintData();
            turtle.DiveMaxDuration = GetNumberFromConsole("Podaj jak długo może nurkować zwierze: ");
            turtle.Swim();
            turtle.GenerateSound();

            Console.WriteLine("Tworzymy zwierze latające - mucha - fly");
            var fly = new Fly(GetNumberFromConsole("Jak duża jest mucha?: "), GetNumberFromConsole("Ile waży?: "));
            fly.PrintData();
            fly.FlyMaxDuration = GetNumberFromConsole("Podaj jak długo może latać?: ");
            fly.Flyy();

            Console.ReadKey();
        }
        static int GetNumberFromConsole(string message)
        {
            bool isCorrect = false;
            int result = 0;
            while (!isCorrect)
            {
                try
                {
                    Console.WriteLine(message);
                    result = int.Parse(Console.ReadLine());
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podaj liczbę..");
                }
            }
            return result;
        }
    }
}
