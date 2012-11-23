using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        readonly NumberStringList _romanLibrary;

        public RomanNumerals()
        {
            _romanLibrary = new NumberStringList
                {
                    {1, "I"},
                    {4, "IV"},
                    {5, "V"},
                    {9, "IX"},
                    {10, "X"},
					{40, "XL"},
                    {50, "L"},
                    {90, "XC"},
                    {100, "C"},
                    {400, "CD"},
                    {500, "D"},
                    {900, "CM"},
                    {1000, "M"},
                    {4000, "MV"},
                    {5000, "V"},
                };
        }        

        public string Convert(int decimalNumber)
        {
            string convertedNumeral = "";
            int currentVal = decimalNumber;

            while (currentVal > 0)
            {
                var nearestNumber = _romanLibrary.GetNearestNumber(currentVal);
                currentVal -= nearestNumber.Item1;
                if (currentVal >= 0) convertedNumeral += nearestNumber.Item2;
            }

            return convertedNumeral;
        }
    }
}
