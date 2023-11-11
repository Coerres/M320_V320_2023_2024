using System;

namespace Browser_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Simulatorr simulator = new Simulatorr();
            simulator.Runhere();
        }
    }

    public class Simulatorr : Simulator
    {
        private StringStack urlStack = new StringStack();

        public void Runhere()
        {
            while (true)
            {
                Console.Write("Geben Sie eine URL ein:");
                string url = Console.ReadLine();

                if (url == "e")
                {
                    break;
                }

                BrowseURLhere(url);
            }
        }

        private void BrowseURL(string url)
        {
            Console.WriteLine($"Lade {url}");
            urlStack.Push(url); // Die URL zum Stack hinzufügen
            DisplayStackInformation();
        }

        private void DisplayStackInformation()
        {
            Console.WriteLine($"Anzahl Elemente im Stack: {urlStack.Count}");
            Console.WriteLine($"Stack ist {(urlStack.IsEmpty ? "leer" : "nicht leer")}");
            Console.WriteLine($"Stack ist {(urlStack.IsFull ? "voll" : "nicht voll")}");
            Console.WriteLine($"Top-Element im Stack: {urlStack.Peak()}");
            Console.WriteLine("---------");
        }
    }
}
