using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    internal class Simulator
    {
        private StringStack stack = new StringStack();
        //memberwvariable
        private string currentUrl;
        public void Run()
        {
            while(true)
            {
                DisplayURL();
                Console.Write("Geben Sie eine URL ein:");
                string url = Console.ReadLine();
                switch(url)
                {
                    case "e":
                        Environment.Exit(0);
                        break;

                    case "p":
                        Undo();
                        break;

                    default:
                    BrowseURLhere(url);
                        break;

                }
                
                
                if (url  == "e")
                {
                    break;
                }
                
            }
        }

        private void BrowseURLhere(string url)
        {
            Console.WriteLine($"Lade {url}");
            stack.Push(url);
            currentUrl = url;
        }

        private void Undo()
        {
            if (stack.Count > 0)
            {
                currentUrl= stack.Pop();
            }
            else
            {
                Console.WriteLine("Diese Funktion ist momentan nicht möglich");
            }
        }

        private void DisplayURL()
        {
            Console.WriteLine($"Die aktuelle URL ist");
        }

    }
}
