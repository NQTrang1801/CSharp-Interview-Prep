public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 0;
        bool isPrev = false;
        for (int i = 1; i < nums.Length; i++) {
            bool isCurr = nums[count] == nums[i];
            if (!isPrev || !isCurr)
                nums[++count] = nums[i];
            isPrev = isCurr;
        }

        return count+1;
    }

    public static void Main(string[] args) {
        Solution solution = new Solution();

        int[] nums1 = {1, 1, 1, 2, 2, 3};
        Console.WriteLine(solution.RemoveDuplicates(nums1));
        Console.WriteLine(String.Join(" ", nums1));

        int[] nums2 = {0, 0, 1, 1, 1, 1, 2, 3, 3};
        Console.WriteLine(solution.RemoveDuplicates(nums2));
        Console.WriteLine(String.Join(" ", nums2));
    }
}

