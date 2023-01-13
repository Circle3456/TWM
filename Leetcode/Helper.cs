using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Helper
    {
        public int MostWordsFound(string[] sentences)
        {
            int numberOfWords = 0;
            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(' ');
                if (words.Length > numberOfWords)
                    numberOfWords = words.Length;
            }
            return numberOfWords;
        }

        public bool CheckTree(TreeNode root)
        {
            if (root.left == null || root.right == null)
                return false;

            return root.val == root.left.val + root.right.val;
        }
    }
}
