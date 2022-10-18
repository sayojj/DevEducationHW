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

        [TestCase(2, 4, 13)]
        [TestCase(-4, -2, -8)]
        [TestCase(4, -2, -4)]
        public static void SolutionsOfTheEquationTest(int first_number, int second_number, int expected)
        {
            int actual = Variables.SolutionsOfTheEquation(first_number, second_number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("a", "b", "ba")]
        [TestCase("2", "4", "42")]
        [TestCase("qqq", "222", "222qqq")]
        public static void SwapTheValueTest(string first_number, string second_number, string expected)
        {
            string actual = Variables.SwapTheValue(first_number, second_number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 6, 2)]
        [TestCase(-4, -2, 10, -3)]
        [TestCase(-10, -1, -4, 0)]
        [TestCase(-3, 12, -6, 6)]
        public static void SolutionOfTheLinearEquationTest(int first_number, int second_number, int third_number, int expected)
        {
            int actual = Variables.SolutionOfTheLinearEquation(first_number, second_number, third_number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 4, 3, "-1 * X + 5 = 0")]
        [TestCase(4, 0, 2, -2, "1 * X + -2 = 0")]
        //[TestCase(1, 1, 0, 3, "-1 * X + 5 = 0")] ??????
        public static void EquationOfStraightLineTest(int x1, int x2, int y1, int y2, string expected)
        {
            string actual = Variables.EquationOfStraightLine(x1, x2, y1, y2);
            Assert.AreEqual(expected, actual);
        }
    }
}