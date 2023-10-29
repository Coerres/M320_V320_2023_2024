using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricForms
{
    public class Square : Rectangle
    {
        public float SideLength
        {
            get { return Width; }
            set
            {
                if (value > 0)
                {
                    Width = value;
                    Height = value;
                }
                else
                    throw new ArgumentException("Seitenlänge muss grösser als 0 sein.");
            }
        }

        public Square(float x = 100.0f, float y = 100.0f, float sideLength = 1.0f) 
            : base(x, y, sideLength, sideLength)
        {
            SideLength= sideLength;
        }

        public override void Draw()
        {
            Console.WriteLine($"Zeichne ein Quadrat mit Seitenlänge {SideLength} an Position ({X}, {Y}).");
        }
    }
}
