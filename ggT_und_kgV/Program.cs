using Microsoft.VisualBasic;
using System;



namespace ggT_und_kgV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 16;



            int result1 = MyMath.Calc_ggT(num1, num2);
            int result2 = MyMath.Calc_kgV(num1, num2);



            Console.WriteLine($"Der ggT von {num1} und {num2} ist {result1}");
            Console.WriteLine($"Das kgV von {num1} und {num2} ist {result2}");



            int positiveNumber = MyMath.ReadInt();
            Console.WriteLine("Eingabe positive Zahl: " + positiveNumber);



            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Option aus: ");
                Console.WriteLine("1 - ggT berechnen");
                Console.WriteLine("2 - kgV berechnen");
                Console.WriteLine("3 - Beenden");
                Console.Write("Ihre Auswahl: ");



                int choice = int.Parse(Console.ReadLine());



                if (choice == 3)
                    break;



                Console.Write("Bitte geben Sie die erste Zahl ein: ");
                int num3 = int.Parse(Console.ReadLine());



                Console.Write("Bitte geben Sie die zweite Zahl ein: ");
                int num4 = int.Parse(Console.ReadLine());



                if (choice == 1)
                {
                    int gcd = MyMath.Calc_ggT(num3, num4);
                    Console.WriteLine($"Der ggT von {num3} und {num4} ist: {gcd}");
                }
                else if (choice == 2)
                {
                    int lcm = MyMath.Calc_kgV(num3, num4);
                    Console.WriteLine($"Der kgV von {num3} und {num4} ist: {lcm}");
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie 1, 2 oder 3.");
                }
            }



            Console.WriteLine("Programm wird beendet.");



            // Für die drei Funktionen:
            int arrayLength = 5; // Anzahl der Zahlen im Array
            int[] numbersArray = MyMath.ReadNumbersArray(arrayLength);



            double mean = MyMath.CalculateMean(numbersArray);
            int minValue = MyMath.MinValue(numbersArray);
            int maxValue = MyMath.MaxValue(numbersArray);



            Console.WriteLine($"Arithmetischer Mittelwert: {mean}");
            Console.WriteLine($"Kleinster Wert: {minValue}");
            Console.WriteLine($"Größter Wert: {maxValue}");



            int num5 = 5;
            int num6 = 10;



            Console.WriteLine($"Vor dem Tausch: num5 = {num5}, num6 = {num6}");



            MyMath.Swap(ref num5, ref num6);



            Console.WriteLine($"Nach dem Tausch: num5 = {num5}, num6 = {num6}");



            // Funktion, die den Inhalt eines übergebenen Arrays vertauscht
            int[] numbers = { 1, 4, 7, 2, 0 };



            Console.WriteLine("Vor der Umkehrung: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();



            MyMath.ReverseArray(numbers);



            Console.WriteLine("Nach der Umkehrung: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}