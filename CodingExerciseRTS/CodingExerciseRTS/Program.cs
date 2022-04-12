using System;
using System.Collections.Generic;

namespace CodingExerciseRTS
{
    class Program
    {
        static void Main()
        {
            // AboveBelow Params
            int[] nums = { 1, 5, 2, 1, 10 };
            int target = 6;

            // StringRotation Params
            var originalString = "MyString";
            int rotationAmount = 2;

            // AboveBelow Method
            // Can't show this in the console as a Dictionary object.
            var aboveBelowResults = AboveBelow(nums, target);
            foreach (var result in aboveBelowResults)
            {
                Console.WriteLine($"{result.Key}: {result.Value}");
            }

            // StringRotation Method
            Console.WriteLine(StringRotation(originalString, rotationAmount));
        }

        public static Dictionary<string, int> AboveBelow(int[] nums, int target)
        {

            var results = new Dictionary<string, int>()
            {
                {"above", 0},
                {"below", 0}
            };

            if (nums == null)
            {
                return results;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    continue;
                }

                if (nums[i] > target)
                {
                    results["above"]++;
                };
                results["below"]++;
            }

            return results;
        }

        public static String StringRotation(String originalString, int rotationAmount)
        {
            if (String.IsNullOrEmpty(originalString) || rotationAmount <= 0)
            {
                return originalString;
            }

            for (int i = 0; i < rotationAmount; i++)
            {
                originalString = originalString[^1] + originalString[..^1];
            }

            return originalString;
        }
    }
}
