namespace DevEduHomework
{
    public static class Variables
    {
        public static int DivisionOfTwoNumbers(int numerator, int denominator)
        {
            int result = numerator / denominator;
            return result;
        }
        public static int SolutionsOfTheEquation(int first_number, int second_number)
        {
            int result = (5 * first_number + second_number*second_number) / (second_number - first_number);
            return result;
        }
        public static string SwapTheValue(string first_write, string second_write)
        {
            string temp = first_write;
            first_write = second_write;
            second_write = temp;
            return first_write + temp;
        }
        public static int SolutionOfTheLinearEquation(int first_number, int second_number,int third_number)
        {
            int result = (third_number - second_number) / first_number;
            return result;
        }
        public static string EquationOfStraightLine(int x1, int x2, int y1, int y2)
        {
            double a = (double)(y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;
            return $"{a} * X + {b} = 0";
        }
    }
}
