using NUnit.Framework;

namespace DevEduHomework.Tests
{
    public class VariablesTests
    {
        [TestCase(3, 3, 1)]
        [TestCase(2, 4, 0)]
        [TestCase(-4, -2, 2)]
        [TestCase(4, -2, -2)]


        public void DivisionOfTwoNumbersTest(int numerator, int denominator, int expected)
        {
            int actual = Variables.DivisionOfTwoNumbers(numerator, denominator);

            Assert.AreEqual(expected, actual);
        }
        /*public void SolutionsOfTheEquation(int numerator, int denominator, int expected)
        {
            int actual = Variables.DivisionOfTwoNumbers(numerator, denominator);

            Assert.AreEqual(expected, actual);
        }
*/
    }
}