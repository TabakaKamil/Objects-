using System;

namespace Objects
{
    abstract class WaterAnimal : Animal
    {
        public WaterAnimal(int Height, int Weigth) : base(Height, Weigth) { }
        abstract public void Swim();
        public int DiveMaxDuration;
    }
}
