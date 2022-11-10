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
        public static int LargestDivisor(int number)
        {
            int i = 2;
            while (number % i != 0)
            {
                i++;
            }
            int result = number / i;
            return result;
        }
        public static int SumOfTheNumbersDivisibleSeven(int first_number, int second_number)
        {
            if (first_number == second_number)
            {
                throw new ArgumentException("first number equal to second");
            }
            int result = 0;
            if (first_number > second_number)
            {
                for (int i = first_number; i < first_number; i++)
                {
                    if (i % 7 == 0)
                    {
                        result = result + i;
                    }
                }
            }
            if (first_number > second_number)
            {
                for (int i = first_number; i < second_number; i++)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }
            return result;
        }
        public static int TheNumberOfTheFibonacci(int number)
        {

            int a = 0;
            int b = 1;
            int result = 1;
            if (number <= 0)
            {
                throw new ArgumentException("zero or negative number");
            }
            else
                for (int i = 2; i < number; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }

        public static int GreatestCommonDivisor(int first_number, int second_number)
        {
            if (first_number <= 0 || second_number <= 0)
            {
                throw new ArgumentException("first or second number negative or equal to zero");
            }
            int result = 1;
            if (first_number > second_number)
                for (int i = 1; i < second_number; i++)
                {
                    if (first_number % i == 0 && second_number % i == 0)
                    {
                        result = i;
                    }
                }
            else
            {
                for (int i = 1; i < first_number; i++)
                {
                    if (first_number % i == 0 && second_number % i == 0)
                    {
                        result = i;
                    }
                }
            }
            return result;
        }
    }
}
