using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DevEduHomework
{
    public static class CustomArray
    {
        public static int FindMinValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("the length of the array is zero");
            }
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                int crnt = array[i];
                if (min > crnt)
                {
                    min = crnt;
                }
            }
                return min;
        }
        public static int FindMaxValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("the length of the array is zero");
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                int crnt = array[i];
                if (max < crnt)
                {
                    max = crnt;
                }
            }
                return max;
        }
        public static int FindIndexOfMinValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("the length of the array is zero");
            }
            int min = array[0];
            int result = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    result = i;
                }
            }
            return result;
        }

        public static int FindIndexOfMaxValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("the length of the array is zero");
            }
            int max = array[0];
            int result = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    result = i;
                }
            }
            return result;
        }
        public static int FindSumOfNumbersIndex(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("the length of the array is zero");
            }
            int result = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                result += array[i];
            }
            return result;
        }
    }
}
