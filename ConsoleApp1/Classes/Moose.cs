using System;
using ConsoleApp1.Enum;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
   
        public class Moose:Animal, IMoose //Crocodil
        {
        public Moose(AnimalType animalType) : base(animalType)
        {
        }

        public void Hunt()
            {
                Console.WriteLine("Moose Shekar Mikonad"); 
            }

        public override void Move()
        {
            Console.WriteLine("move method for moose Class ");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat method for moose class");
        }
    }

 }

