using System;

namespace IntroToOop
{
    class Cat
    {
        //States

        private string name; //Fields
        private int age;
        private string furColor;
        private bool isHungry;

        public string Name
        {
            get {return this.Name}
            set { this.Name = value}
        }
           

        //Constructors where the class behaves
        public Cat() //Default Constructor no parameter are always need when creating a new constructor 
        {

        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;

        }

        public void Eat() //Method
        {
            if(isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine( "Is the cat hungry? " + isHungry);
        }

    }
}
