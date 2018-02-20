using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_1_twosum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whatever I write here");
            var name = Console.ReadLine();
            int[] Input = { -1,-2,-3,-4,-5};
            int Target = -8;
            Solution s1 = new Solution();
            int[] result = s1.TwoSumV2(Input, Target);
            Array.ForEach(result, s => Console.Out.WriteLine(s));
            name = Console.ReadLine();
        }
    }
    class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] Result = { 0, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    continue;
                }
                else
                {
                    int rest_target = target - nums[i];
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] == rest_target & j!= i)
                        {
                            Result[0] = i + 1;
                            Result[1] = j + 1;
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
            }
            return Result;
        }
        public int[] TwoSumV2(int[] nums, int target)
        {
            int[] HarlValue = new int[2];
            int Hidx = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int idx = 0; idx<nums.Length; idx++)
            {
                if (nums[idx]*2 == target)
                {
                    HarlValue[Hidx] = idx;
                    if (Hidx == 1)
                        return HarlValue;
                    else
                        Hidx++;
                }
                else
                {
                    if (!dictionary.ContainsKey(nums[idx]))
                        dictionary.Add(nums[idx], idx);
                }
            }
            //var dictionary = Enumerable.Range(0, nums.Length).ToDictionary(x => nums[x]);
            int len = nums.Length;
            foreach (var item in dictionary)
            {
                    var rest = target - item.Key;
                    if (dictionary.ContainsKey(rest) )
                        if (item.Value != dictionary[rest])
                        {
                            int a = item.Value ;
                            int b = dictionary[rest];
                            int[] result = { a, b };
                            return result;
                        }
            }
            return new int[2];
        }
    }
}
