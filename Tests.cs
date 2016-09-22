using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void OneConvertsToI() 
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.Equal(romanNumerals.convertToNumeral(1), "I");
        }

        [Fact]
        public void TwoConvertsToII() 
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.Equal(romanNumerals.convertToNumeral(2), "II");
        }

        [Fact]
        public void ThreeConvertsToIII() 
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.Equal(romanNumerals.convertToNumeral(3), "III");
        }
        [Fact]
        public void FourConvertsToIV() 
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.Equal(romanNumerals.convertToNumeral(4), "IV");
        }
        [Fact]
        public void FiveConvertsToV() 
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.Equal(romanNumerals.convertToNumeral(5), "V");
        }
        [Fact]
        public void TenConvertsToX() 
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.Equal(romanNumerals.convertToNumeral(10), "X");
        }
        [Fact]
        public void OneThousandConvertsToM() 
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.Equal(romanNumerals.convertToNumeral(1000), "M");
        }
    }
}
