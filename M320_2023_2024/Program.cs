namespace M320_2023_2024 //Testzusammenfassung
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        
        }
        
        //Klassenvererbungen
        // Klasse Person
        public class Person
        {
           
            public string Name { get; set; }
            public int Age { get; set; }

            public void Greet()
            {
                Console.WriteLine("Hello, I'm " + Name);
            }
        }

        // Klasse Student erbt von Person
        public class Student : Person
        {
            public int StudentId { get; set; }

            public void Study()
            {
                Console.WriteLine("Studying...");
            }
        }


        //Assoziation (Klassen existieren unabhängig von einander 
        public class Teacher
        {
            public string Name { get; set; }
        }

        public class Student
        {
            public string Name { get; set; }
            public Teacher Teacher { get; set; } // Assoziation zu einer Lehrkraft
        }

        //Aggregation können unabhängig vom Ganzen existieren
        public class Department
        {
            public string Name { get; set; }
            public List<Employee> Employees { get; set; } // Aggregation von Mitarbeitern
        }

        public class Employee
        {
            public string Name { get; set; }
        }


        //Komposition, Lebensdauer der Teilobjekte vom Ganzen abhängt
        public class Car
        {
            public Engine Engine { get; set; } // Komposition von Motor
            public Wheel[] Wheels { get; set; } // Komposition von Rädern
        }

        public class Engine
        {
            // Eigenschaften und Methoden für den Motor
        }

        public class Wheel
        {
            // Eigenschaften und Methoden für Räder
        }
        $


        // Superklasse (Basisklasse)
        public class Animal
        {
            public string Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }
        }

        // Subklasse (abgeleitete Klasse)
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Woof woof!");
            }
        }


        public abstract class Shape
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string Color { get; set; }

            public abstract void Draw();
        }


        //Vererbung (Abstrakt)
        public class Circle : Shape
        {
            public int Radius { get; set; }

            public override void Draw()
            {
                // Implementierung zum Zeichnen eines Kreises
            }
        }

        public class Rectangle : Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public override void Draw()
            {
                // Implementierung zum Zeichnen eines Rechtecks
            }
        }

        //Vererbung
        public class Animal
        {
            public string Name { get; set; }

            public Animal(string name)
            {
                Name = name;
            }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }
        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }

            public void Bark()
            {
                Console.WriteLine("Woof woof!");
            }
        }

        // Verwendung
        Dog myDog = new Dog("Fido");
        myDog.Eat();  // Geerbte Methode von Animal
        myDog.Bark(); // Eigene Methode von Dog


        //public
        public class Superclass
        {
            public int PublicField;
        }

        public class Subclass : Superclass
        {
            public void AccessSuperclassField()
            {
                int value = base.PublicField; // Zugriff auf das öffentliche Feld der Superklasse
            }
        }

        //private
        public class Superclass
        {
            private int PrivateField;
        }

        public class Subclass : Superclass
        {
            public void AccessSuperclassField()
            {
                // Das private Feld der Superklasse ist in der Subklasse nicht sichtbar.
                // Ein Zugriffsversuch würde einen Compilerfehler verursachen.
                // int value = base.PrivateField; // Dies ist nicht erlaubt.
            }
        }

        //protected
        public class Superclass
        {
            protected int ProtectedField;
        }

        public class Subclass : Superclass
        {
            public void AccessSuperclassField()
            {
                int value = base.ProtectedField; // Zugriff auf das geschützte Feld der Superklasse
            }
        }


        //Syntax zur Deklaration der Generalisierung 
        public class Fahrzeug
        {
            public string Marke { get; set; }
            public string Modell { get; set; }

            public void Starten()
            {
                Console.WriteLine("Das Fahrzeug wird gestartet.");
            }
        }

        public class Auto : Fahrzeug
        {
            public int AnzahlDerTüren { get; set; }

            public void Hupen()
            {
                Console.WriteLine("Hup hup!");
            }
        }


        //Vererbungshierachie
        // Basisklasse Animal
        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Animal(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public virtual void MakeSound()
            {
                Console.WriteLine("Das Tier macht einen unbekannten Laut.");
            }
        }

        // Subklasse Bird (Vogel)
        public class Bird : Animal
        {
            public string FeatherColor { get; set; }

            public Bird(string name, int age, string featherColor)
                : base(name, age)
            {
                FeatherColor = featherColor;
            }

            public override void MakeSound()
            {
                Console.WriteLine("Der Vogel zwitschert.");
            }
        }

        // Subklasse Mammal (Säugetier)
        public class Mammal : Animal
        {
            public string FurColor { get; set; }

            public Mammal(string name, int age, string furColor)
                : base(name, age)
            {
                FurColor = furColor;
            }

            public override void MakeSound()
            {
                Console.WriteLine("Das Säugetier macht Geräusche.");
            }
        }

        // Subklasse Dog (Hund)
        public class Dog : Mammal
        {
            public Dog(string name, int age, string furColor)
                : base(name, age, furColor)
            {
            }

            public void Bark()
            {
                Console.WriteLine("Der Hund bellt.");
            }
        }

        Bird sparrow = new Bird("Spatz", 2, "Braun");
        sparrow.MakeSound();  // Der Vogel zwitschert.

        Dog goldenRetriever = new Dog("Buddy", 3, "Goldenes Fell");
        goldenRetriever.MakeSound();  // Das Säugetier macht Geräusche.
        goldenRetriever.Bark();  // Der Hund bellt.


        //Überschreiben von Methoden
        public class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a generic shape.");
            }
        }

        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle.");
            }
        }

        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a rectangle.");
            }
        }


        //Verwendung von Schnittstellen
        public interface IComparable
        {
            int CompareTo(object other);
        }

        public class Student : IComparable
        {
            public int CompareTo(object other)
            {
                // Vergleichslogik für Studenten implementieren
            }
        }

        public class Book : IComparable
        {
            public int CompareTo(object other)
            {
                // Vergleichslogik für Bücher implementieren
            }
        }


        //Polymorphie in Collections
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle());
        shapes.Add(new Rectangle());

        foreach (Shape shape in shapes)
        {
        shape.Draw(); // Polymorphe Ausführung von Draw basierend auf dem tatsächlichen Typ des Objekts.
        }



}
}
