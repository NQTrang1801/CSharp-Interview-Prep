using System;

// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, 
// representing the number of elements in nums1 and nums2 respectively.

// Merge nums1 and nums2 into a single array sorted in non-decreasing order.

// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, 
// and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

// Constraints: nums1.length == m + n | nums2.length == n | 0 <= m, n <= 200 | 1 <= m + n <= 200 | -109 <= nums1[i], nums2[j] <= 109
// Follow up: Can you come up with an algorithm that runs in O(m + n) time?

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (n == 0) return;

        int end_idx = nums1.Length - 1;

        while (m > 0 && n > 0) {
            if (nums1[m-1] < nums2[n-1]) {
                nums1[end_idx] = nums2[n-1];
                n--;
            } else {
                nums1[end_idx] = nums1[m-1];
                m--;
            }

            end_idx--;
        }

        while(n > 0) {
            nums1[end_idx] = nums2[n-1];
            n--;
            end_idx--;
        }
    }

    public static void Main(string[] args) {
        Solution solution = new Solution();

        // EX1
        int[] nums1 = {1, 2, 3, 0, 0, 0};
        int m = 3;
        int[] nums2 = {2, 5, 6};
        int n = 3;
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine("Merged array: " + string.Join(", ", nums1)); // Output: 1, 2, 2, 3, 5, 6

        // EX2
        nums1 = new int[] {1};
        m = 1;
        nums2 = new int[] {};
        n = 0;
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine("Merged array: " + string.Join(", ", nums1)); // Output: 1

        // EX3
        nums1 = new int[] {0};
        m = 0;
        nums2 = new int[] {1};
        n = 1;
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine("Merged array: " + string.Join(", ", nums1)); // Output: 1
    }
}
