using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Mannschaft
    {
        public List<Feldspieler> Feldspieler { get; set; }
        public Torwart Torwart { get; set; }

        public Mannschaft()
        {
            Feldspieler = new List<Feldspieler>();
        }

        // Methode to add 'Feldspieler' to 'Mannschaft'
        public void AddFeldspieler(Feldspieler spieler)
        {
            if (Feldspieler.Count < 10)
            {
                Feldspieler.Add(spieler);
            }
            else
            {
                Console.WriteLine("Die Mannschaft ist bereits voll. Sie können keinen weiteren Feldspieler hinzufügen.");
            }
        }

        // Methode to asign 1 'Torwart' to 'Mannschaft'
        public void SetTorwart(Torwart torwart)
        {
            if (Torwart == null)
            {
                Torwart = torwart;
            }
            else
            {
                Console.WriteLine("Die Mannschaft hat bereits einen Torwart.");
            }
        }

    }
}
