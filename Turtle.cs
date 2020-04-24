using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class Turtle : WaterAnimal
    {
        public Turtle(int Height, int Weigth) : base(Height, Weigth) { }
        public override void Swim()
        {
            Console.WriteLine("Zółw wodny potrafi pływać!");

        }
        public override void GenerateSound()
        {
            Console.WriteLine("Przykładowy dzwięk żółwia wodnego...");
        }
    }
}
