using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Dog
    {
        //declare fields
        private string name;
        private string hairLength;
        private int height;
        private int runningSpeed;
        private string weight;
        
        //declare properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //default constructor
        public Dog()
        {

        }

        // loaded constructor
        public Dog(string hairLength, int height, int runningSpeed, string weight, string name)
        {
            this.name = name;
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }
        public void Run()
        {
            Console.WriteLine("The dog runs {0} mph!", runningSpeed);
        }
        public void Bark()
        {
            Console.WriteLine("The dogs bark is loud!");
        }
        public void Potty()
        {
            Console.WriteLine("The dog needs the potty!");
        }
        public void Cuddle()
        {
            Console.WriteLine("The dog loves to cuddle!");
        }

        
        
    }
}
