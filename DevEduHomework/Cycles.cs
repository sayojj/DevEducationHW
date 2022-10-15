using System;

namespace DevEduHomework
{
    public static class Cycles
    {
        public static int Exponentiation(int number, int degree)
        {
            int result = number;
            for (int i = 1; i < degree; i++)
            {
                result = number * result;
            }
                return result;
        }
        public static int SquareIsLessThanNumber(int number)
        {
            int result = 1;
            for (int i = 1; i < 1000; i++)
            {
                if (i % number == 0)
                {
                    result = i;
                }
            }
            return result;
        }
    }
}
