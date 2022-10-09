using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            int result = 1;
            string nums = num.ToString();

            for (int i = 0; i < nums.Length; i++)
            {
                result *= (int)Char.GetNumericValue(nums[i]);
            }
            return result;
        }
    }
}
