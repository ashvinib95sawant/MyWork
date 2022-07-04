using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //1.Interface
    public interface Drawable
    {
        void draw();
        static void Area()
        {
            Console.WriteLine("Area");
        }
    }
    public class rectangle:Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class circle:Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
    public class Itest
    {
        static void Main(string[] args)
        {
            Drawable d;
            d = new rectangle();
            d.draw();
            Drawable.Area();
            d = new circle();
            d.draw();
        }
    }

    //2.Interface

    public interface IMovable
    {
        void show();
       
    }
    public interface IDrawable
    {
        public static int X=70;
        void draw();
        static void Fill()
        {
            Console.WriteLine("Fill shape");
        }
        public void Move()
        {
            Console.WriteLine("Move to shape");
        }

    }
   
    public class Circle : IDrawable,IMovable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle");
        }
        public void show()
        {
            Console.WriteLine("Movable circle");
        }

    }
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.draw();
            c.show();
            IDrawable.Fill();
            IDrawable d = new Circle();
            d.Move();
        }
    }

    //1.Abstraction

    abstract class Animal
    {
        public int x = 200;
        public static string name = "Shiv";

        public abstract void eat();

        public Animal(string y)//Constructor
        {
            Console.WriteLine("name of Animal "+ y);
        }
        public void show()
        {
            Console.WriteLine("This is Animal");
        }
    }

    class Dog:Animal
    {
        public Dog():base("Rockey")
        {
            Console.WriteLine("Dog name is Rockey");
        }
        public override void eat()
        {
            Console.WriteLine("Dog is eating "+x+" "+name);
        }

    }
    class aDemo
    {
        static void Main(string[] args)
        {
            Animal aa = new Dog();
            aa.eat();
            aa.show();
        }
    }
}
