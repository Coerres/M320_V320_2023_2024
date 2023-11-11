using System;

namespace Browser_Simulator
{
    public class StringStack
    {
        string[] values;
        int index;

        public StringStack()
        {
            values = new string[10];
        }

        public void Push(string value)
        {
            if (index < 10)
            {
                this.values[index++] = value;
                Console.WriteLine("Stack ist befüllt.");
            }
            else
            {
                Console.WriteLine("Stack ist voll.");
            }
        }

        public string Pop()
        {
            if (index > 0)
            {
                index--;
                Console.WriteLine("Stack ist befüllt.");
                return this.values[index];
            }
            else
            {
                Console.WriteLine("Stack ist leer.");
                return null;
            }
        }

        public string Peak()
        {
            if (index > 0)
            {
                return this.values[index - 1];
            }
            else
            {
                Console.WriteLine("Stack ist leer.");
                return null;
            }
        }
    }
}
