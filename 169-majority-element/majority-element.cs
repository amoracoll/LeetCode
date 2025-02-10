public class Solution {
    public int MajorityElement(int[] nums) {
        // int finalNumber = 0;
        // int generalCounter = 0;

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     int localCounter = 0;

        //     for (int x = 0; x < nums.Length; x++)
        //     {
        //         if (nums[i] != nums[x])
        //         {
        //             continue;
        //         }

        //         localCounter++;
        //     }

        //     if (generalCounter > localCounter)
        //     {
        //         continue;
        //     }

        //     generalCounter = localCounter;
        //     finalNumber = nums[i];
        // }

        // return finalNumber;

        int candidate = nums[0];
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }
}