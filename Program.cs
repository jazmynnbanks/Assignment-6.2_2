static int[] ProductExceptSelf(int[] nums)
{

    int[] leftProducts = new int[nums.Length];
    int[] rightProducts = new int[nums.Length];
    int[] results = new int[nums.Length];

    leftProducts[0] = 1;

    for (int i = 1; i < nums.Length; i++)
    {
        leftProducts[i] = nums[i - 1] * leftProducts[i - 1];
    }

    rightProducts[nums.Length - 1] = 1;

    for (int i = nums.Length - 2; i >= 0; i--)
    {
        rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
    }

    for (int i = 0; i < nums.Length; i++)
    {
        results[i] = leftProducts[i] * rightProducts[i];
    }
    return results;
}

int[] nums = { 1, 2, 3, 4 };
int[] result = ProductExceptSelf(nums);

Console.WriteLine("Results: ");
Console.WriteLine(string.Join(", ", result));