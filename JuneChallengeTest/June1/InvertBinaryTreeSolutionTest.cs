using Microsoft.VisualStudio.TestTools.UnitTesting;
using JuneChallenge.June1;
using FluentAssertions;
namespace JuneChallengeTest.June1

{
    [TestClass]
    public class InvertBinaryTreeSolutionTest
    {
        [TestMethod]
        public void InvertTree_Test()
        {
            //Arrange 
            TreeNode inputTreeNode = new TreeNode();
            inputTreeNode.val = 4;
            inputTreeNode.left = new TreeNode
            {
                val = 2,
                left = new TreeNode
                {
                    val = 1
                },
                right = new TreeNode
                {
                    val = 3
                }
            };
            inputTreeNode.right = new TreeNode
            {
                val = 7,
                left = new TreeNode
                {
                    val = 6
                },
                right = new TreeNode
                {
                    val = 9
                }
            };

            TreeNode outputTreeNode = new TreeNode();
            outputTreeNode.val = 4;
            outputTreeNode.right = new TreeNode
            {
                val = 2,
                right = new TreeNode
                {
                    val = 1
                },
                left = new TreeNode
                {
                    val = 3
                }
            };
            outputTreeNode.left = new TreeNode
            {
                val = 7,
                right = new TreeNode
                {
                    val = 6
                },
                left = new TreeNode
                {
                    val = 9
                }
            };
            //Act
            InvertBinaryTreeSolution solution = new InvertBinaryTreeSolution();
            var invertedTree = solution.InvertTree(inputTreeNode);
            //Assert

            invertedTree.Should().BeEquivalentTo(outputTreeNode);
        }
    }
}
