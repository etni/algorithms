using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class BinarySearchTests
    {
        //          4
        //         / \
        //        2   6
        //       / \   \
        //      1   3   7
        public Node TestTree() => new Node(4, new Node(2, new Node(1), new Node(3)), new Node(6, null, new Node(7)));

        [Fact]
        public void ShouldTraverseInOrder()
        {
            var node = TestTree();

            var result = BinarySearch.InOrder(node);

            var expected = new List<int>() { 1, 2, 3, 4, 6, 7 };

            Assert.Equal(expected, result);

        }

        [Fact]
        public void ShouldTraversePreOrder()
        {

            var node = TestTree();

            var result = BinarySearch.PreOrder(node);

            var expected = new List<int>() { 4,2,1,3,6,7 };

            Assert.Equal(expected, result);

        }

        [Fact]
        public void ShouldFindAValue()
        {
            var node = TestTree();

            var result = BinarySearch.Search(node, 6);

            Assert.NotNull(result);
            Assert.Equal(6, result.Value);
        }

        [Fact]
        public void ShouldNotFindAValue()
        {
            var node = TestTree();

            var result = BinarySearch.Search(node, 9);

            Assert.Null(result);
 
        }

    }
}
