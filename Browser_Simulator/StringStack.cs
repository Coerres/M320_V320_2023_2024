using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.values[index++] = value;

            if (index < 0)
            {
                Console.WriteLine("Stack ist leer.");
            }
            else if (index >= 0 || index <= 8)
            {
                Console.WriteLine("Stack ist befüllt.");
            }
            else if (index == 9)
            { 
 
                Console.WriteLine("Stack ist voll.");
            }

        }

        public string Pop()
        {
            index--;

            if (index < 0)
            {
                Console.WriteLine("Stack ist leer.");
            }
            else if (index >= 0 || index <= 8)
            {
                Console.WriteLine("Stack ist befüllt.");
            }
            else if (index == 9)
            {

                Console.WriteLine("Stack ist voll.");
            }
            return this.values[index];

        }

        public string Peak()
        {
            return this.values[index];
        }
    }
}
