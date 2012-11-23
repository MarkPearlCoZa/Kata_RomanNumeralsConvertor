using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        readonly NumberTextList _romanLibrary;

        public RomanNumerals()
        {
            _romanLibrary = new NumberTextList
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


        public string Convert(int number)
        {
            string convertedNumeral = string.Empty;
            int adjustedNumber = number;

            while (adjustedNumber > 0)
            {
                var nearestSmallestNumber = _romanLibrary.GetNearestNumber(adjustedNumber);                
                convertedNumeral += nearestSmallestNumber.Text;
                adjustedNumber -= nearestSmallestNumber.Number;
            }

            return convertedNumeral;
        }
    }
}
