using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public abstract class Person
    {   
        public string Name { get; set; }
        public string Vorname { get; set; }
        public int Id { get; set; }

        public virtual void Esse()
        {
            Console.WriteLine($"Person: {Vorname} {Name} {Id} isst mit Messer und Gabel");
        }

        //public virtual void Trage()
        //{
        //    Console.WriteLine($"Person {Vorname} {Name} trägt mit ...");
        //}

        public abstract void Trage();
    }
}
