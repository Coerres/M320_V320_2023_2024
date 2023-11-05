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


    }
}
