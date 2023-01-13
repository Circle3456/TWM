using Leetcode;

namespace LeetcodeTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }, 6)]
    [TestCase(new string[] { "please wait", "continue to fight", "continue to win" }, 3)]
    public void 在句子陣列中最多字的句子是幾個字(string[] sentences, int expect)
    {
        //Arrange
        Helper helper = new Helper();

        //act
        var actualResult = helper.MostWordsFound(sentences);

        //Assert
        Assert.That(actualResult, Is.EqualTo(expect));
    }

    [Test]
    public void 陣列元素2和3相加等於陣列元素1的值()
    {
        //Arrange
        Helper helper = new Helper();
        TreeNode root1 = new TreeNode()
        {
            val = 2,
            left = new TreeNode() { val = 1 },
            right = new TreeNode() { val = 1 }
        };

        TreeNode root2 = new TreeNode()
        {
            val = 3,
            left = new TreeNode() { val = 1 },
            right = new TreeNode() { val = 1 }
        };

        //act
        bool actualResult1 = helper.CheckTree(root1);
        bool actualResult2 = helper.CheckTree(root2);

        //Assert
        Assert.IsTrue(actualResult1);
        Assert.IsFalse(actualResult2);
    }
}