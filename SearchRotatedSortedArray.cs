//Used binary search
//found the search space by comparing mid with nums[high] and high[low] value of nums array
//Depending on the target, if target is in one half we  redce search space to that half.
//TC: O(logN)
//SC: O(1) No extra space used

public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Count() - 1;
        
        while(low<=high){
            int mid = low +(high-low)/2;
            
            if(nums[mid] == target){
                return mid;
            }
            if(nums[mid]>=nums[low]){
                if(target<nums[mid] && target >= nums[low]){
                    high = mid-1;
                }else{
                    low = mid+1;
                }
            }else{
                if(target>nums[mid] && target <= nums[high]){
                    low = mid+1;
                }else{
                    high = mid -1;
                }
            }
        }
        
        return -1;
    }
}