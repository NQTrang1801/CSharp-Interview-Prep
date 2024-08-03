public class Solution {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        int[] candys = new int[n];
        candys[0] = 1;

        // Duyệt từ trái sang phải
        for (int i = 1; i < n; i++) {
            if (ratings[i] > ratings[i - 1]) {
                candys[i] = candys[i - 1] + 1;
            } else {
                candys[i] = 1;
            }
        }

        int sum = candys[n - 1];

        // Duyệt từ phải sang trái
        for (int i = n - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1]) {
                candys[i] = Math.Max(candys[i], candys[i + 1] + 1);
            }
            sum += candys[i];
        }

        return sum;

    }

    public static void Main(String[] args) {
        Solution solution = new Solution();
        int[] nums = {1, 2, 87, 87, 87, 2, 1};
        Console.WriteLine(solution.Candy(nums));

    }
}