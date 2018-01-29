using System;

namespace IntroToOop
{
    internal class Superhero
    {
        private bool hasCape;
        private bool hasBoots;
        private bool hasSuperPowers;
        private bool canFly;

        public bool HasCape
        {
            get { return this.hasCape; } //get allows to see value of name
            set { this.hasCape = true; } //set will allow you to set name
        }

        public bool HasBoots
        {
            get { return this.hasBoots; }
            set { this.hasBoots = true; }
        }

        public bool HasSuperPowers
        {
            get { return this.hasSuperPowers; }
            set { this.hasSuperPowers = true; }
        }

        public bool CanFly
        {
            get { return this.canFly; }
            set { this.canFly = true; }
        }

        public Superhero()
        {
            //Default
        }

        public Superhero(bool hasCape, bool hasBoots, bool hasSuperPowers, bool canFly)
        {
            this.hasCape = hasCape;
            this.hasBoots = hasBoots;
            this.hasSuperPowers = hasSuperPowers;
            this.canFly = canFly;
        }

        public void Cape()
        {
            if (hasCape)
            {
                Console.WriteLine("Our Super hero has a cape");
            }
            else
            {
                Console.WriteLine("Our Super hero is naked");
            }
        }

        public void Boots()
        {
            if (hasBoots)
            {
                Console.WriteLine("Nice boots!");
            }
            else
            {
                Console.WriteLine("Go put on boots!");
            }
        }

        public void Powers()
        {
            if (hasSuperPowers)
            {
                Console.WriteLine("Watch out!");
            }
            else
            {
                Console.WriteLine("Go get your powers Mr. Super Hero");
            }
        }

        public void Fly()
        {
            if (canFly)
            {
                Console.WriteLine("Look out!");
            }
            else
            {
                Console.WriteLine("What kind of super hero are you?");
            }
        }
    }
}

//Create a class Superhero
//The class Superhero should have 4 fields
//An example might be strengthLevel or hasCape
//The class Superhero should have 4 Properties
//An example might be StrengthLevel or SecretIdentity
//The class Superhero should have 3 Constructors
//The class Superhero should have at least two methods
//One method should impact the Superhero’s health(could be Health, could be StrengthLevel, could be Speed, etc.)
//One method should give your Superhero a power boost. (could be EatsSpinach() or AbsorbsYellowSun(), etc.)