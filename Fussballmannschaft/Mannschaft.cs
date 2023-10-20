using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Mannschaft
    {
        public List<Feldspieler> Feldspieler { get; set; }
        public Torwart? Torwart { get; set; }

        public Mannschaft()
        {
            Feldspieler = new List<Feldspieler>();
            Torwart = null;
        }

        public void AddFeldspieler(Feldspieler feldspieler)
        {
            Feldspieler.Add(feldspieler);
        }
        public void AddSpiel(Spiel spiel)
        {
            spiel.Mannschaften.Add(this);
        }

        public void SetTorwart(Torwart torwart)
        {
            Torwart = torwart;
        }
        public int Spielzug()
        {
            int tore = 0;

            // Torwart does an action
            if (Torwart != null)
            {
                if (Torwart.HalteTor())
                {
                    Console.WriteLine("Torwart hat das Tor gehalten!");
                    tore--;
                }
                else
                {
                    Console.WriteLine("Torwart hat ein Tor zugelassen!");
                    tore++;
                }
            }

            // Feldspieler does an action
            foreach (var spieler in Feldspieler)
            {
                if (spieler.SchiesseTor())
                {
                    Console.WriteLine("Feldspieler hat ein Tor geschossen!");
                    tore++;
                }
                else
                {
                    Console.WriteLine("Feldspieler hat das Tor verfehlt!");
                }
            }

            return tore;



            /*
             // Methode to add 'Feldspieler' to 'Mannschaft'
            public void AddFeldspieler(Feldspieler spieler)
        {
            if (Feldspieler.Count < 10)
            {
                Feldspieler.Add(spieler);
            }
            else
            {
                Console.WriteLine("Die Mannschaft ist bereits voll.");
            }
        }

        // Methode to assign 1 'Torwart' to 'Mannschaft'
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
            */
        }
            


    }
}
