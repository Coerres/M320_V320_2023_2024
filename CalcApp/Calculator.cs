using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CalcApp
{
    public class Calculator
    {
        private int lastResult; //Internes Feld zur Speicherung des letzten Ergenisses.



        public int LastResult
        {
            get { return lastResult; }
        }



        public int Add(int a, int b)
        {
            lastResult = a + b;
            return lastResult;
        }
        public int Add(int a)
        {
            lastResult += a;
            return lastResult;
        }



        public int Subtract(int a, int b)
        {
            lastResult = a - b;
            return lastResult;
        }
        public int Subtract(int a)
        {
            lastResult -= a;
            return lastResult;
        }



        public int Multiply(int a, int b)
        {
            lastResult = a * b;
            return lastResult;
        }
        public int Multiply(int a)
        {
            lastResult *= a;
            return lastResult;
        }
        public int Divide(int a, int b)
        {
            //The number zero isn't allowed to divide
            if (b == 0)
            {
                throw new ArgumentException("Division durch null ist nicht erlaubt.");
            }
            lastResult = a / b;
            return lastResult;
        }
        public int Divide(int a)
        {
            if (a == 0)
            {
                throw new ArgumentException("Division durch null ist nicht erlaubt.");
            }
            lastResult /= a;
            return lastResult;
        }



    }
}