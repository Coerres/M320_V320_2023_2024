using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Spiel
    {
        public Resultat SpielResultat { get; set; }

        public List<Mannschaft> Mannschaften { get; set; }
        public Spiel()
        {
            Mannschaften = new List<Mannschaft>();
            SpielResultat = new Resultat();
        }
    }
}
