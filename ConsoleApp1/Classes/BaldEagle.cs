using System;
using ConsoleApp1.Enum;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{

    public class BaldEagle : Animal, IEagle //OqabeTalayi
    {
        public BaldEagle(AnimalType animalType) : base(animalType)
        {
        }

        public void Hunt()
        {
            Console.WriteLine("BaldEagle Shekar Mikonad");
        }



        public override void Move()
        {
            Console.WriteLine("move method for BaldEagle class");

        }

        public override void Eat()
        {
            Console.WriteLine("Eat method for BaldEagle class");

        }
    }

}

