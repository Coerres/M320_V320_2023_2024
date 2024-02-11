using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Auto_IMS_cc
{
    public class Auto
    {
        private Motor motor;

        public Auto()
        {
            motor = new Motor();
        }
        public void Anlassen()
        {
            Console.WriteLine("Auto anlassen");
            motor.Starten();
        }
    }
}
