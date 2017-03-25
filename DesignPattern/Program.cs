using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.CreationalPattern.AbstractFactory;
using DesignPattern.CreationalPattern.AbstractFactory.Example2;
namespace DesignPattern
{
    class Program
    {
        /// <summary>
        /// abstract factory pattern is a creational pattern in which interfaces are defined
        /// for creating families of related objects without specifying their actual implementations
        /// 
        /// whe using this pattern, you create factories which return many kinds of related objects.
        /// Participants : 1-abstract Factory, 2-Conceret Factory, 3-Abstract Product, 4-Conceret Product, 5-Client [uses abstract factory, and abstract products]
        /// 
        /// Example:
        /// lets say we want to model 2 kinsds of recipes: a sandwich and a dessert, and let is make assumption that adults and kids
        /// do not eat the same things, and so we want one of each kind of reecipe for adults and for kids.
        /// AbstractProduct [sandwich, dessert] : abstract class represnts generic kind of recipes.
        /// Abstract Factory : abstract class that will return a Sandwich and a Dessert.
        /// ConcreteProduct  : implementing the actual objects.
        /// ConcreteFactory  : implements the AbstractFactory 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            VechileFactory honda = new HondaFactory();
            ClientVechile hondaClient = new ClientVechile(honda, "regular");

            Console.WriteLine("*** Honda ***");
            Console.WriteLine(hondaClient.GetBikeName());
            Console.WriteLine(hondaClient.GetCarName());

            hondaClient = new ClientVechile(honda, "sport");
            Console.WriteLine(hondaClient.GetBikeName());
            Console.WriteLine(hondaClient.GetCarName());
            

            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;


            Recipe factory;

            switch(input){

                case 'A': factory = new Adult();
                    break;

                case 'B': factory = new Kids();
                    break;

                default: throw new NotImplementedException();

            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\n sandwich" + sandwich.GetType().Name);
            Console.WriteLine("\n dessert" + dessert.GetType().Name);

            Console.ReadLine();


        }
    }
}
