using System;
using System.Collections.Generic;

namespace dotnet_binary_tree

{
    class MainClass
    {
        // Create a binary tree of Nodes
        /*       a
              /     \
            b         c
           / \       /  \ 
          d   e     f    g
                   /    
                  h

        */
        public static Node binaryTree =
          new Node("a",
            new Node("b",
              new Node("d"),
              new Node("e")),
            new Node("c",
              new Node("f",
                new Node("h")),
              new Node("g"))
          );

        public static void Main(string[] args)
        {
            // DFS needs to take results list as argument and then return it
            List<string> results = new List<string>();
            Console.WriteLine("Depth-first-search traversal of binary tree:");
            DFSTraveral(binaryTree, results).ForEach(i => Console.Write("{0}\t", i)); ;

            Console.WriteLine("\n");

            // BFS can maintain its own results lsit
            Console.WriteLine("Breadth-first-search traversal of binary tree:");
            BFSTraveral(binaryTree).ForEach(i => Console.Write("{0}\t", i));
        }
        // Depth-first-search traversal
        public static List<string> DFSTraveral(Node node, List<string> list)
        {
            // Break condition - if node is null return
            if (node == null) return list;

            // If node has value add it to the list
            list.Add(node.Value);

            // Recursively traverse the list, starting on the left
            DFSTraveral(node.Left, list);
            DFSTraveral(node.Right, list);

            return list;
        }

        // Breadth-first-search traversal
        public static List<string> BFSTraveral(Node node)
        {
            // Create an array (list?) of Nodes (queue)
            List<Node> queue = new List<Node>();
            List<string> results = new List<string>();
            queue.Add(node);

            // While loop-- while there are items on the queue, Console.WriteLine the
            // value at index 0, check if there is a node.Left and if so add to queue,
            // check if there is a node.Right and if so add to queue, and finally remove
            // the first item (shift) from the queue. (or pop and check the last element)
            while (queue.Count > 0)
            {
                results.Add(queue[0].Value);
                if (queue[0].Left != null) queue.Add(queue[0].Left);
                if (queue[0].Right != null) queue.Add(queue[0].Right);
                queue.RemoveAt(0);
            }

            return results;
        }
    }
}
