using CombinationSum;

namespace CominationSum.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        int[] candidates = { 2, 3, 6, 7 };
        int target = 7;
        var result = _test.CombinationSumMethod(candidates, target);
        IList<IList<int>> answer = new List<IList<int>>();
        IList<int> answer1 = new List<int>() { 2, 2, 3 };
        IList<int> answer2 = new List<int>() { 7 };
        answer.Add(answer1);
        answer.Add(answer2);

        bool isEqual = true;

        for (int i = 0; i < answer.Count; i++)
        {
            if (!answer[i].SequenceEqual(result[i]))
            {
                isEqual = false;
            }
        }

        Assert.IsTrue(isEqual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] candidates = { 2, 3, 5 };
        int target = 8;
        var result = _test.CombinationSumMethod(candidates, target);
        IList<IList<int>> answer = new List<IList<int>>();
        IList<int> answer1 = new List<int>() { 2, 2, 2, 2 };
        IList<int> answer2 = new List<int>() { 2, 3, 3 };
        IList<int> answer3 = new List<int>() { 3, 5 };
        answer.Add(answer1);
        answer.Add(answer2);
        answer.Add(answer3);

        bool isEqual = true;

        for (int i = 0; i < answer.Count; i++)
        {
            if (!answer[i].SequenceEqual(result[i]))
            {
                isEqual = false;
            }
        }

        Assert.IsTrue(isEqual);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        int[] candidates = { 2 };
        int target = 1;
        var result = _test.CombinationSumMethod(candidates, target);
        IList<IList<int>> answer = new List<IList<int>>();

        bool isEqual = true;

        for (int i = 0; i < answer.Count; i++)
        {
            if (!answer[i].SequenceEqual(result[i]))
            {
                isEqual = false;
            }
        }

        Assert.IsTrue(isEqual);
    }
}