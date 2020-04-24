using System;

namespace Objects
{
    abstract class Animal
    {
        private int Height;
        private int Weigth;

        public Animal(int Height, int Weigth)
        {
            this.Height = Height;
            this.Weigth = Weigth;
        }

        abstract public void GenerateSound();
        public int GetHeight()
        {
            return Height;
        }
        public void SetHeight(int Height)
        {
            this.Height = Height;
        }
        public int GetWeigth()
        {
            return Weigth;
        }
        public void SetWeigth(int Weigth)
        {
            this.Weigth = Weigth;
        }
        public void PrintData()
        {
            Console.WriteLine("Wzrost: " + Height);
            Console.WriteLine("Waga: " + Weigth);
        }
    }
}
