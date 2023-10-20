using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Feldspieler
    {
        public string Name { get; set; }

        public Feldspieler(string name)
        {
            Name = name;
        }

        public void MacheBlutgraetsche()
        {
            Console.WriteLine($"{Name} macht eine Blutgraetsche!");
        }

        public void DribbletGegnerSchwindlig()
        {
            Console.WriteLine($"{Name} dribblet den Gegner schwindlig!");
        }



        public bool SchiesseTor()
        {
            Console.WriteLine($"{Name} schiesst aufs Tor!");
            Random random = new Random();
            return random.Next(100) < 50; //50% chances
        }
    }
}
