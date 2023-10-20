using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Resultat
    {
        public int Team1Ergebnis { get; set; }
        public int Team2Ergebnis { get; set; }

        public Resultat()
        {
            Team1Ergebnis = 0;
            Team2Ergebnis = 0;
        }
    }
}
