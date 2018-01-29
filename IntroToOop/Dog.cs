using System;

namespace IntroToOop
{
    internal class Dog
    {
        private string hairLength;
        private double height;
        private int runningSpeed;
        private double weight;

        public string HairLength
        {
            get { return this.hairLength; } //get allows to see value of name
            set { this.hairLength = value; } //set will allow you to set name
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Dog()
        {
            //Default constructor
        }

        public Dog(string hairLength, double height, int runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run()
        {
            Console.WriteLine("Slow down spot");
        }

        public void Bark()
        {
            Console.WriteLine("/a");
        }

        public void Potty()
        {
            Console.WriteLine("Go potty spot");
        }

        public void Cuddle()
        {
            Console.WriteLine("Lets cuttle spot");
        }
    }
}

//Create a class Dog
//The class Dog should have the following fields
//hairLength
//height
//runningSpeed
//weight

//The class should have the following behaviors
//Run()
//Bark()
//Potty()
//Cuddle()