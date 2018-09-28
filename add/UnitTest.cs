using System;
using System.Numerics;
using Xunit;

namespace addnumber
{
    public class UnitTest
    {
        [Fact]
        public void When_Add_Two_Very_Large_Number_Should_Be_Respond_Result()
        {
            BigInteger input1 = BigInteger.Parse("893880539957604781622135818781054154760092");
            BigInteger input2 = BigInteger.Parse("458875111557430000227050141224806041518870");
            BigInteger expected = BigInteger.Parse("1352755651515034781849185960005860196278962");

            Calculator addNumber = new Calculator();
            BigInteger actual = addNumber.add(input1, input2);

            Assert.Equal(expected, actual);
        }
    }
}
