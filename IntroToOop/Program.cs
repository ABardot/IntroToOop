using System;

namespace IntroToOop
{
    internal class Program
    {
        private static void Main()
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat();

            secondCat.Meow();

            Dog firstDog = new Dog();
            firstDog.Run();
            firstDog.Bark();
            firstDog.Potty();
            firstDog.Cuddle();

            Superhero superhero = new Superhero();
            superhero.Cape();
            superhero.Boots();
            superhero.Powers();
            superhero.Fly();
        }
    }
}