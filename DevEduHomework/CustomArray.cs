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
        public static int FindMixValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length = 0");
            }
            int mix = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                int crnt = array[i];
                if (mix > crnt)
                {
                    mix = crnt;
                }
            }
                return mix;
        }
        public static int FindMaxValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length = 0");
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
    }
}
