using System;
using System.Collections.Generic;

class BinaryTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
        }
    }
    int i = 0;
    Node root;
    public Node rec(string[] str, int n)
    {
        Node root = new Node(int.Parse(str[i]));
        i++;
        if (str[i] == "true")
        {
            i++;
            root.left = rec(str, n);
        }
        else
            i++;
        if (str[i] == "true")
        {
            i++;
            root.right = rec(str, n);
        }
        else
            i++;
        return root;
    }
    public void CreateBT()
    {
        string[] str = Console.ReadLine().Split();
        int n = str.Length;
        i = 0;
        root = rec(str, n);
    }

    public int Sum()
    {
        return Sum(root);
    }

    public int Sum(Node root)
    {
        if (root == null)
        {
            return 0;
        }
        return root.data + Sum(root.left) + Sum(root.right);
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.CreateBT();
            int Value = bt.Sum();
            Console.Write(Value);
            Console.Read();
        }
    }
}