using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class TupleListTests
    {

        [TestCase(3,"I")]
        [TestCase(24,"X")]
        [TestCase(999,"CM")]
        public void ShouldReturnTheNumberNearestToTheValue(int numberToSearchFor, string expectedReturnText)
        {
            var list = new NumberStringList()
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

            var result = list.GetNearestNumber(numberToSearchFor);
            Assert.That(result.Item2, Is.EqualTo(expectedReturnText));
        }

        [TestCase(10,"A")]
        [TestCase(20,"B")]
        [TestCase(30,"C")]
        public void ShouldReturnTheNumberEqualToTheValue(int numberToSearchFor, string expectedReturnText)
        {
            var list = new NumberStringList()
            {
                {10,"A"},
                {20,"B"},
                {30,"C"}
            };

            var result = list.GetNearestNumber(numberToSearchFor);
            Assert.That(result.Item2, Is.EqualTo(expectedReturnText));
        }
    }
}