using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricForms
{
    public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }
        public double RotationAngle { get; set; }

        public Shape(float x, float y)
        {
            X = y;
            Y = y;
            RotationAngle = 0.0; //standard rotation 0
        }


        //methods
        public abstract void Draw();
        public abstract void Move(float deltaX, float deltaY);
        public abstract void Rotate(double angle);

    }
}
