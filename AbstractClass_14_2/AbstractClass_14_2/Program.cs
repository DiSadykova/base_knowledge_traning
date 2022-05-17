using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();;
            cat1.ShowInfo();
            Dog dog1 = new Dog();
            dog1.ShowInfo();
            Console.ReadKey();


        }
    }
    abstract class Animal
    {
        public abstract string NameAnimal { get; set; }
        public Animal(string nameAnimal = "животное")
        {

        }
        public abstract void Say();
        public virtual void ShowInfo()
        {
            Console.WriteLine(NameAnimal);
            Say();
        }
    }
    class Cat : Animal
    {
        public string name;
        public override void Say()
        {
            Console.WriteLine("Мяу");
            
        }
        public override string NameAnimal
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Cat() 
            :base()
        {
            NameAnimal = "Кошка";
        }
    }
    class Dog : Animal
    {
        public string name;
        public override void Say()
        {
            Console.WriteLine("Гав");

        }
        public override string NameAnimal
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Dog()
            : base()
        {
            NameAnimal = "Собака";
        }
    }
}

