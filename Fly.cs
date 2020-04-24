using System;

namespace Objects
{
    class Fly : AirAnimal
    {
        public Fly(int Height, int Weigth) : base(Height, Weigth) { }
        public override void GenerateSound()
        {
            Console.WriteLine("Przykładowy dzwięk muchy...");
        }
        public override void Flyy()
        {
            Console.WriteLine("Mucha potrafi latać...");
        }
    }
}
