using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{

    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }


        public Node(int value, Node left = default, Node right = default)
        {
            Value = value;
            Left = left;
            Right = right;
        }

    }


    public static class BinarySearch
    {
        public static List<int> InOrder(Node node)
        {

            var list = new List<int>();

            if (node == null)
                return new List<int>();

            var result = new List<int>();
            result.AddRange(InOrder(node.Left));
            result.Add(node.Value);
            result.AddRange(InOrder(node.Right));


            return result;
        }

        public static List<int> PreOrder(Node node)
        {

            var list = new List<int>();

            if (node == null)
                return new List<int>();

            var result = new List<int>();
            result.Add(node.Value);
            result.AddRange(PreOrder(node.Left));
            result.AddRange(PreOrder(node.Right));
            return result;
        }

        public static Node Search(Node node, int value)
        {
            if (node == null || node.Value == value)
                return node;

            return value < node.Value ? Search(node.Left, value) : Search(node.Right, value);

        }
    }



}
