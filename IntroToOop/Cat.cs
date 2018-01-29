using System;

namespace IntroToOop
{
    internal class Cat //When ever we create a class its a noun
    {
        //States

        private string name; //Fields
        private int age;
        private string furColor;
        private bool isHungry;

        public string Name
        {
            get { return this.name; } //get allows to see value of name
            set { this.name = value; } //set will allow you to set name
        }

        //Constructors where the class behaves
        public Cat()
        {
            //Default Constructor no parameter are always need when creating a new constructor
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat() //Method are verbs
        {
            if (isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }
    }
}