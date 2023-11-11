using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    public class Simulator
    {
        public void Run()
        {
            while(true)
            { 
                Console.Write("Geben Sie eine URL ein:");
                string url = Console.ReadLine();
                if (url  == "e")
                {
                    break;
                }
                BrowseURLhere(url);
            }
        }

        public void BrowseURLhere(string url)
        {
            Console.WriteLine($"Lade {url}");
        }
    }
}
