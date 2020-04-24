using System;

namespace Objects
{
    abstract class AirAnimal : Animal
    {
        public AirAnimal(int Height, int Weigth) : base(Height, Weigth) { }
        abstract public void Flyy();
        public int FlyMaxDuration;
    }
}
