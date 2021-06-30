public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] indices = {};
        int j = 0;
        for(int i =j+1;i<nums.Length;i++)
            {         
               int val  = nums[j];
               int matchval = val+nums[i];
               if(matchval == target)
                {
                    indices = new int[] {i,j};
                    break;
                }   
                else
                {
                    if(i == nums.Length-1)
                    {
                        ++j;
                        i = j;
                    }
                }
            }
         return indices;
    }
}