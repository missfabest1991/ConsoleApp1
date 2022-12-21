using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Animal;

namespace ConsoleApp1
{
    internal class Program
    {
        IAlligator _ialligator;
        IMoose _moose;
        IEagle _ieagle;

       
        Program(IEagle ieagle, IAlligator ialligator, IMoose moose)
        {
            _ieagle = ieagle;
            _ialligator = ialligator;
            _moose = moose;

        }
        static void Main(string[] args)
        {
            Alligator alligator = new Alligator();
            alligator.Move();
            alligator.Eat();
            Moose moose = new Moose();  
            moose.Move();
            moose.Eat();
            BaldEagle baldEagle = new BaldEagle();  
            baldEagle.Move();
            baldEagle.Eat();
        }







    }




     public abstract class Animal  
    {
        public string TypeOfAnimal { get; set; }
        public int SumOfHandAndLeg { get; set; }
        public abstract void Move();
        public abstract void Eat();




        public Animal( )
            {
            TypeOfAnimal = TypeOfAnimal;

            }


     


       public class Alligator: IAlligator  //GavazneShomali

        {
            
            

            public void AlligatorMethod()
            {
                
                var Alligator= EnumTypeAnimal.Pestandar;
                var SumOfHandAndLeg = 4;
                Console.WriteLine(Alligator);
                Console.WriteLine(Alligator + " " + SumOfHandAndLeg);



                Console.ReadKey();
            }

            public  void Hunt()
            {

                Console.WriteLine("Alligator shekar mikonad") ;
                
            }

            public void Move()
            {
                Console.WriteLine("move method for Alligator class");
            }

            public void Eat()
            {
                Console.WriteLine("Eat method for Alligator class");
            }

           
        }

        public class Moose:IMoose //Crocodil
        {
            public void Hunt()
            {
                Console.WriteLine("Moose Shekar Mikonad"); 
            }

            public void MooseMethod()
            {
                var Moose = EnumTypeAnimal.khazande;
                var SumOfHandAndLeg = 4;
                Console.WriteLine(Moose);
                Console.WriteLine(Moose + " " + SumOfHandAndLeg);

                Console.ReadKey();
            }

            public void Move()
            {
                Console.WriteLine("move for moose Class ");
            }

            public void Eat()
            {
                Console.WriteLine("Eat method for moose class");
            }

        }

        public class BaldEagle:IEagle //OqabeTalayi
        {
            
            public void BaldEagleMethod()
            {
                

                var BaldEagle = EnumTypeAnimal.Parande;
                var SumOfHandAndLeg = 2;
                Console.WriteLine(BaldEagle);
                Console.WriteLine(BaldEagle+ " " + SumOfHandAndLeg);
                Console.ReadKey();
            }

           

            public void Hunt()
            {
                Console.WriteLine("BaldEagle Shekar Mikonad");
            }

            public void Move()
            {
                Console.WriteLine("move method for BaldEagle class");
            }
            public void Eat()
            {
                Console.WriteLine("Eat method for BaldEagle class");
            }
        }



        public enum EnumTypeAnimal
        {

            khazande ,
            Parande ,
            Pestandar

        }

        public interface IMoose
        {
            void Hunt();
           
        }

        public interface IEagle
        {
            void Hunt();
        }

        public interface IAlligator
        {
            void Hunt();
        }

    }
}
