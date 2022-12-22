using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Classes;
using ConsoleApp1.Enum;
using ConsoleApp1.Interfaces;


namespace ConsoleApp1
{
    public class Program
    {
        IAlligator _ialligator;
        IMoose _moose;
        IEagle _ieagle;

       
        public Program(IEagle ieagle, IAlligator ialligator, IMoose moose)
        {
            _ieagle = ieagle;
            _ialligator = ialligator;
            _moose = moose;

        }
        static void Main(string[] args)
        {
            #region Alligator
            Alligator alligator = new Alligator(AnimalType.khazande);
            alligator.HandLeg = 4;
            alligator.Move();
            alligator.Eat();
            Console.WriteLine($"Sum of HandLegs Aligator :{alligator.HandLeg}, And AnimalType is {AnimalType.khazande}");
            alligator.Hunt();
            #endregion

            Console.WriteLine("---------------------------------------------");
            #region Moose
            Moose moose = new Moose(AnimalType.Pestandar);  
            moose.HandLeg = 4;
            moose.Move();
            moose.Eat();
            Console.WriteLine($"Sum of HandLegs Moose :{moose.HandLeg}, And AnimalType is {AnimalType.Pestandar}");
            moose.Hunt();
            #endregion

            Console.WriteLine("---------------------------------------------");
            #region BaldEagle
            BaldEagle baldEagle = new BaldEagle(AnimalType.Parande);  
            baldEagle.HandLeg = 2;
            baldEagle.Move();
            baldEagle.Eat();
            Console.WriteLine($"Sum of HandLegs BaldEagle :{baldEagle.HandLeg}, And AnimalType is {AnimalType.Parande}");
            baldEagle.Hunt();
            #endregion
            Console.ReadKey();
        }

    }
}
