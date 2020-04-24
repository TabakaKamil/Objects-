using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class Tortoise : LandAnimal
    {
        public Tortoise(int Height, int Weigth) : base(Height, Weigth) { }
        public override void GenerateSound()
        {
            Console.WriteLine("Przykładowy dzwięk żółwia...");
        }
    }
}
