using NUnit.Framework;

namespace DevEduHomework.Tests
{
    public class CustomArrayTests
    {
        [TestCase(new int[] { 7, 7, 7, 7, 7 }, 7)]
        [TestCase(new int[] { 1, -19, 44, 0 }, -19)]
        [TestCase(new int[] { 0 }, 0)]
        public void FindMinValueTest(int[] array, int expected)
        {
            int actual = CustomArray.FindMinValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindMinValueTest_WhenArrayIsEmptyException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => CustomArray.FindMinValue(array));
        }
    }
}