using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    public class Wasserfass
    {
        readonly int minimalPegel;
        readonly int maximalPegel;
        readonly int fuellstand;
        readonly int kapazitaet;


        public void Befuellen()
        {
            int menge;
        }

        public void Entnehmen()
        {
            int menge;
        }

        public void Entleeren()
        {

        }

        public void MinimalPegel()
        {
           if (minimalPegel >= 0)
            {
                Console.WriteLine("Der Minimalpegel beträgt 0.");
            }
        }

        public void MaximalPegel()
        {
            if (maximalPegel >= 0)
            {
                Console.WriteLine("Der Minimalpegel beträgt 0.");
            }
        }


    }
}
