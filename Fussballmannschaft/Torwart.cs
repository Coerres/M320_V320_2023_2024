using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Torwart
    {
        public string Name { get; set; }

        public Torwart(string name) 
        { 
            Name = name;
        }

        public bool HalteTor() //another name for 'SchussHalten'
        {
            Console.WriteLine($"{Name} hält den Schuss vom Gegner!");
            Random random = new Random();
            return random.Next(100) < 70; //70% chances that he catches the ball
        }

        public void Abstoss()
        {
            Console.WriteLine($"{Name} macht einen Abstoss!");
        }
    }
}
