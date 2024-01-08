using System;
using System.Collections.Generic;

// Base class demonstrating encapsulation and inheritance
public class Animal
{
    private string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }

    public string GetName()
    {
        return name;
    }
}

// Derived class demonstrating polymorphism and method overriding
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Interface demonstrating interface inheritance
public interface IJumpable
{
    void Jump();
}

// Another interface demonstrating interface inheritance
public interface ISwimmable
{
    void Swim();
}

// Class implementing multiple interfaces
public class Dolphin : Animal, ISwimmable
{
    public Dolphin(string name) : base(name)
    {
    }

    public void Swim()
    {
        Console.WriteLine("Dolphin swims");
    }
}

// Abstract class demonstrating abstract classes and methods
public abstract class Shape
{
    public abstract void Draw();
}

// Concrete class implementing the abstract class
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism example
        Animal myAnimal = new Dog("Buddy");
        myAnimal.MakeSound();

        // Interface inheritance example
        Dolphin flipper = new Dolphin("Flipper");
        flipper.Swim();

        // Abstract class and method example
        Circle myCircle = new Circle();
        myCircle.Draw();

        // Collection classes example
        List<string> names = new List<string>();
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        Console.WriteLine("Names in the list:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Properties example
        Dog myDog = new Dog("Rex");
        Console.WriteLine("Dog's name:" + myDog.GetName());
    }
}
