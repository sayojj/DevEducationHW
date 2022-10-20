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
        public static int NumbersUpTo1000Divisible(int number)
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
        public static int RootOfAllSmallerNumbers(int number)
        {
            int result = 1;
            for(int i = 1; i < number; i++)
            {
                if (i * i < number)
                {
                    result = i;
                }
            }
            return result;
        }
        public static int LargestDivisor(int number) //ne rabotaet
        {
            int result = 1;
            int i = 2;
            while (number % i != 0)
            {
                result = number / i;
            }
                i++;
            return result;
        }
        public static int SumOfTheNumbersDivisibleSeven(int first_number, int second_number) //vivodit ne summu a max cilso / 7 v diapazone
        {
            int result = 0;
            while (first_number != second_number)
            {
                first_number++;
                if (first_number % 7 == 0)
                {
                    result = first_number;
                }
            }
            return result;
        }
    }
}
