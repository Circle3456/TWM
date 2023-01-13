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
    public void �b�y�l�}�C���̦h�r���y�l�O�X�Ӧr(string[] sentences, int expect)
    {
        //Arrange
        Helper helper = new Helper();

        //act
        var actualResult = helper.MostWordsFound(sentences);

        //Assert
        Assert.That(actualResult, Is.EqualTo(expect));
    }

    [Test]
    public void �}�C����2�M3�ۥ[����}�C����1����()
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