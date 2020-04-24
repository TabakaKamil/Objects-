using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    abstract class LandAnimal : Animal
    {
        public LandAnimal(int Height, int Weigth) : base(Height, Weigth) { }
        public void Walk()
        {
            Console.WriteLine("Umiejętność chodzenia - zwierze lądowe");
        }
    }
}
