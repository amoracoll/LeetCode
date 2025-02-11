public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }

            seen.Add(num);
        }

        return false;
        
        // bool result = false;
        
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     for (int x = 0; x < nums.Length; x++)
        //     {
        //         if (i == x)
        //         {
        //             continue;
        //         }

        //         if (nums[i] != nums[x])
        //         {
        //             continue;
        //         }

        //         return true;
        //     }
        // }

        // return false;
    }
}