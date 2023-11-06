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
        }
        
        public string Pop()
        {
            index--;
            return this.values[index];
        }
    }
}
