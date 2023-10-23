using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Person
    {   
        public string Name { get; set; }
        public string Vorname { get; set; }

        public void Esse()
        {
            Console.WriteLine($"Person: {Vorname} {Name} isst mit Messer und Gabel");
        }
    }
}
