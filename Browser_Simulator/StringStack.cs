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

        public void Clear()
        {
            // Lösche alle Daten im Stack
            Array.Clear(values, 0, values.Length);
            index = 0;
            Console.WriteLine("Stack wurde geleert.");
        }

        public bool IsEmpty
        {
            get { return index == 0; }
        }

        public int Count
        {
            get { return index; }
        }

        public bool IsFull
        {
            get { return index == values.Length; }
        }
    }
}
