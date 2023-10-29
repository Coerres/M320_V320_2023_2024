﻿using System;
using System.Collections.Generic;

namespace GeometricForms
{
    public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }
        public double RotationAngle { get; set; }

        public Shape(float x = 100.0f, float y = 100.0f)
        {
            X = x; 
            Y = y; 
            RotationAngle = 0.0; //rotation = 0
        }

        //methods
        public abstract void Draw();
        public abstract void Move(float deltaX, float deltaY);
        public abstract void Rotate(double angle);

        public static void PrintPosition(IEnumerable<Shape> shapes)
        {
            Console.WriteLine("Positionen der Figuren: ");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Position: ({shape.X}, {shape.Y})");
            }
        }
    }


    public class Circle : Shape
    {
        private float radius;
        public float Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentException("Radius muss grösser als 0 sein.");
            }
        }

        public Circle(float x = 100.0f, float y = 100.0f, float radius = 1.0f)
            : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Zeichne einen Kreis mit Radius {Radius} an Position ({X}, {Y}).");
        }

        public override void Move(float deltaX, float deltaY)
        {
            X += deltaX;
            Y += deltaY;
            Console.WriteLine($"Verschiebe den Kreis um ({deltaX}, {deltaY}) nach der Position ({X}, {Y}).");
        }
        public override void Rotate(double angle)
        {
            RotationAngle += angle;
            Console.WriteLine($"Rotiere den Kreis um {angle} Grad.");
        }

        public void PrintPosition()
        {
            Console.WriteLine($"Position des Kreises (Mittelpunkt): ({X}, {Y})");
        }
    }


    public class Rectangle : Shape
    {
        private float width;
        private float height;

        public float Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    throw new ArgumentException("Breite muss grösser als 0 sein.");
            }
        }
        public float Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    throw new ArgumentException("Höhe muss grösser als 0 sein.");
            }
        }

        public Rectangle(float x = 100.0f, float y = 100.0f, float width = 1.0f, float height = 1.0f)
            : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Zeichne ein Rechteck mit Breite {Width} und Höhe {Height} an Position ({X}, {Y}).");
        }

        public override void Move(float deltaX, float deltaY)
        {
            X += deltaX;
            Y += deltaY;
            Console.WriteLine($"Verschiebe das Rechteck um ({deltaX}, {deltaY}) nach Position ({X}, {Y}).");
        }

        public override void Rotate(double angle)
        {
            RotationAngle += angle;
            Console.WriteLine($"Rotiere das Rechteck um {angle} Grad.");
        }

        public void PrintPosition()
        {
            Console.WriteLine($"Position des Rechtecks (obere, linke Ecke): ({X}, {Y})");
            Console.WriteLine($"Position der unteren, rechten Ecke: ({X + Width}, {Y + Height})");
        }
    }
}
 