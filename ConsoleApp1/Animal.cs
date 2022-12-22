using ConsoleApp1.Enum;

namespace ConsoleApp1
{
    public abstract partial class Animal  
    {
        protected Animal(AnimalType animalType)
        {
            AnimalType = animalType;
        }

        public AnimalType AnimalType { get; set; }
        public int HandLeg { get; set; }
        public abstract void Move();
        public abstract void Eat();

    }
}
