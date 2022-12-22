using System;
using ConsoleApp1.Enum;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public class Alligator : Animal, IAlligator  //GavazneShomali
    {
        public Alligator(AnimalType animalType) : base(animalType)
        {
        }

        public void Hunt()
        {
            Console.WriteLine("Alligator shekar mikonad");

        }

        public override void Move()
        {
            Console.WriteLine("move method for Alligator class");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat method for Alligator class");
        }
    }
}
