using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSystem
{
    public class StringStack
    {
        private string[] stackArray;
        private int currentIndex;
        public StringStack(int capacity)
        {
            stackArray = new string[capacity];
            currentIndex = -1; 
        }

        public void Push(string value)
        {

            if (currentIndex == stackArray.Length - 1)
            {
                Console.WriteLine("Stack Overflow! Cannot push more items.");
                return;
            }


            currentIndex++;
            stackArray[currentIndex] = value;

            Console.WriteLine($"Pushed: {value}");
        }

        public string Pop()
        {
            if (currentIndex == -1)
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
                return null;
            }

            string poppedValue = stackArray[currentIndex];
            currentIndex--;

            Console.WriteLine($"Popped: {poppedValue}");
            return poppedValue;
        }
    }
}
