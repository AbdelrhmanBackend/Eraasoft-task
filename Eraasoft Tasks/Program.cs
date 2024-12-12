using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eraasoft_Tasks
{
    internal class Program
    {
        static void ExecuteTaskOne()
        {
            Person Person1 = new Person("Abdelrhman", 21);
            Person Person2 = new Person("Ahmed", 20);

            Person1.PrintDetails();
            Person2.PrintDetails();
        }

        static void ExecuteTaskTwo()
        {
            Dog Dog1 = new Dog("Boby", "Golden");
            Dog Dog2 = new Dog("Meky", "Petpol");

            Dog1.Name = "Wai";
            Dog2.Breed = "Betbol";

            Dog1.PrintDetails();
            Dog2.PrintDetails();
        }

        static void ExecuteTaskThree()
        {
            PremiumMembership Person1 = new PremiumMembership("Ahmed",3,SpaAccessType.NotAllowed,true);
            GoldMembership Person2    = new GoldMembership("Abdelrhman", 3, SpaAccessType.OnceaMonth);
            NormalMembership Person3  = new NormalMembership("Ali", 3);

            Console.WriteLine("Person one fees: {0}", Person1.CalculateFees());
            Person1.Offers();

            Console.WriteLine("Person two fees: {0}", Person2.CalculateFees());
            Person2.Offers();

            Console.WriteLine("Person three fees: {0}", Person3.CalculateFees());
            Person3.Offers();


            Console.WriteLine();


            GymMembership Person;
            
            Person = new PremiumMembership("Ahmed", 2, SpaAccessType.NotAllowed, true);
            Console.WriteLine("Person one fees: {0}", Person.CalculateFees());
            Person.Offers();

            Person = new GoldMembership("Abdelrhman", 2, SpaAccessType.OnceaMonth);
            Console.WriteLine("Person two fees: {0}", Person.CalculateFees());
            Person.Offers();

            Person = new NormalMembership("Ali", 2);
            Console.WriteLine("Person three fees: {0}", Person.CalculateFees());
            Person3.Offers();
        }

        static void ExecuteTaskFour()
        {
            OnlineOrder Order1 = new OnlineOrder(1,"Abdelrhman", DateTime.Now.AddDays(-3),"#3434FR",Address.Others);
            OnlineOrder Order2 = new OnlineOrder(2,"Ayman", DateTime.Now.AddDays(-2), "#3434FX", Address.Cairo);
            OnlineOrder Order3 = new OnlineOrder(3,"Ali" , DateTime.Now, "#3434FM", Address.Alex);

            Console.WriteLine();
            Order1.PrintInformations();

            Console.WriteLine();
            Order2.PrintInformations();

            Console.WriteLine();
            Order3.PrintInformations();
        }

        static void Main(string[] args)
        {
            //ExecuteTaskOne();
            //ExecuteTaskTwo();
            //ExecuteTaskThree();
            //ExecuteTaskFour();

            Console.ReadKey();
        }
    }
}
