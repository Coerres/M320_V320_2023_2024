
using System.ComponentModel;

namespace NumberConverter
{
    /// <summary>
    /// Zur Verf�gung gestellt von Peter Gisler, GIBZ
    /// </summary>
    public class NumberConverter //immer direkt internal --> public
    {

        StringConverter _stringConverter;

        public NumberConverter(StringConverter stringConverter = null)
        {
            _stringConverter = stringConverter;
        }

        public int RoundUp(float value)
        {
            int intValue = (int)value;
            if(value > intValue)
            {
                intValue++;
            }
            return intValue;
        }

        public int RoundDown(float value, int intValue)
        {
            if(value < intValue)
            {
                intValue--;
            }
            return intValue;
        }


        public int RoundToPowerOfTen(float value, int precisionExponent = 1)
        {
            // TODO: Implement rounding... 
            // Math.Round() may be used here
            return 0;
        }

        public int RoundToPowerOfTen(string numericString, int precisionExponent = 1)
        {
            // TODO: Implement rounding...
            // Have a look at the StringConverter utility in this project!
            return 0;
        }

    }
}