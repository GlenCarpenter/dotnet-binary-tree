using System;

namespace dotnet_binary_tree
{
    public class Node
    {
        public String Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        // Multiple constructors so we can create a node with:
        // Value + Left + Right
        public Node(string value, Node left, Node right)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }
        // Value + Left only
        public Node(string value, Node left)
        {
            this.Value = value;
            this.Left = left;
        }
        // Value only
        public Node(string value)
        {
            this.Value = value;
        }
    }
}
