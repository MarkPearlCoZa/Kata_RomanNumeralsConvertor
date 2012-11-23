using NUnit.Framework;

namespace RomanNumberalsTests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        private RomanNumerals.RomanNumerals _romanNumerals;

        [SetUp]
        public void Initialize()
        {
            _romanNumerals = new RomanNumerals.RomanNumerals();
        }

        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(90, "XC")]
        [TestCase(100, "C")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        [TestCase(4000, "MV")]
        [TestCase(5000, "V")]
        public void ShouldConvertPivotalValuesCorrectly(int decimalNumber, string expectedRomanNumeral)
        {
            var result = _romanNumerals.Convert(decimalNumber);
            Assert.That(result, Is.EqualTo(expectedRomanNumeral));
        }

        [TestCase(124, "CXXIV")]
        public void ShouldConverNonPivotalValuesCorrectlty(int decimalNumber, string expectedRomanNumeral)
        {
            var result = _romanNumerals.Convert(decimalNumber);
            Assert.That(result, Is.EqualTo(expectedRomanNumeral));
        }
    }
}