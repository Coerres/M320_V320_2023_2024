using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Auto_IMS_cc
{
    public class Motor
    {
        private Benzinpumpe benzinpumpe;
        private Anlasser anlasser;

        public Motor()
        {
            benzinpumpe = new Benzinpumpe();
            anlasser = new Anlasser();
        }

        public void Starten()
        {
            Console.WriteLine("Motor starten");
            benzinpumpe.Pumpen();
            anlasser.Starten();
            Regeln();
            anlasser.Stoppen();
        }

        private void Regeln()
        {
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine("Motor regeln");
            }
        }
    }
}
