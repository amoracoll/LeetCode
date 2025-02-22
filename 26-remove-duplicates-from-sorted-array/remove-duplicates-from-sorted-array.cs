public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0)
        {
            return 0;
        }
        
        int writeIndex = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                continue;    
            }

            nums[writeIndex] = nums[i];
            writeIndex++;
        }

        return writeIndex;
    }
}