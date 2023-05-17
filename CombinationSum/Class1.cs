namespace CombinationSum;
public class Class1
{
    public IList<IList<int>> result = new List<IList<int>>();

    public IList<IList<int>> CombinationSumMethod(int[] candidates, int target)
    {
        IList<int> list = new List<int>();
        FindSolution(candidates, target, list, 0, 0);
        return result;
    }

    public void FindSolution(int[] nums, int target, IList<int> list, int sum, int index)
    {
        if (sum == target)
        {
            result.Add(list.ToArray());
            return;
        }

        while (sum < target && index < nums.Length)
        {
            list.Add(nums[index]);
            FindSolution(nums, target, list, sum + nums[index], index);
            list.RemoveAt(list.Count - 1);
            index++;
        }
    }
}
