using System;
using System.Globalization;



namespace CalcApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcApp.Calculator calculator = new CalcApp.Calculator();



            //Eingabe des ersten Wertes
            Console.Write("Geben Sie den ersten Wert ein: ");
            int num1 = Convert.ToInt32(Console.ReadLine());



            //Eingabe des zweiten Wertes
            Console.Write("Geben Sie den zweiten Wert ein: ");
            int num2 = Convert.ToInt32(Console.ReadLine());



            //Auswahlmöglichkeiten
            Console.WriteLine("Wählen Sie eine Option aus:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");



            int choice = Convert.ToInt32(Console.ReadLine());
            int result = 0;





            switch (choice)
            {
                case 1:
                    result = calculator.Add(num1, num2);
                    Console.WriteLine($"Addition: {result}");
                    break;
                case 2:
                    result = calculator.Subtract(num1, num2);
                    Console.WriteLine($"Subtraktion: {result}");
                    break;
                case 3:
                    result = calculator.Multiply(num1, num2);
                    Console.WriteLine($"Multiplikation: {result}");
                    break;
                case 4:
                    try
                    {
                        result = calculator.Divide(num1, num2);
                        Console.WriteLine($"Division: {result}");
                    }
                    catch (ArgumentException ex) //Hier wird ggf.'ArgumentException' ausgelöst. (weil 0)
                    {
                        Console.WriteLine($"Fehler: {ex.Message}"); //das 'ex' verweist auf die Meldung
                    }
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }





            Console.WriteLine("Geben Sie einen weiteren Wert ein:");



            int num3 = Convert.ToInt32(Console.ReadLine());



            //Verwenden der überladenen Methoden mit einem einzelnen int-Parameter
            //Eingabe von einem weiteren Wert
            switch (choice)
            {
                case 1:
                    result = calculator.Add(num3);
                    Console.WriteLine($"Addition mit einem Wert: {result}");
                    break;
                case 2:
                    result = calculator.Subtract(num3);
                    Console.WriteLine($"Subtraktion mit einem Wert: {result}");
                    break;
                case 3:
                    result = calculator.Multiply(num3);
                    Console.WriteLine($"Multiplikation mit einem Wert: {result}");
                    break;
                case 4:
                    try
                    {
                        result = calculator.Divide(num3);
                        Console.WriteLine($"Division mit einem Wert: {result}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Fehler: {ex.Message}");
                    }
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }





            //Zugriff auf das letzte Ergebnis
            Console.WriteLine($"Letzte Ergebnis: {calculator.LastResult}");



        }
    }
}