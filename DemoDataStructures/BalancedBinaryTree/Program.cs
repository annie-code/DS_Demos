using System;

namespace BalancedBinaryTree
{
    class Node
    {

       int data;
        public Node left, right;

      public  Node(int d)
        {
            data = d;
            left = right = null;
        }
    }
    // Calculate height
    class Height
    {
       public int height = 0;
    }

    class BinaryTree
    {

        Node root;

        // Check height balance
       public bool checkHeightBalance(Node root, Height height)
        {

            // Check for emptiness
            if (root == null)
            {
                height.height = 0;
                return true;
            }

            Height leftHeighteight = new Height(), rightHeighteight = new Height();
            bool l = checkHeightBalance(root.left, leftHeighteight);
            bool r = checkHeightBalance(root.right, rightHeighteight);
            int leftHeight = leftHeighteight.height, rightHeight = rightHeighteight.height;

            height.height = (leftHeight > rightHeight ? leftHeight : rightHeight) + 1;

            if ((leftHeight - rightHeight >= 2) || (rightHeight - leftHeight >= 2))
                return false;

            else
                return l && r;
        }


        class Program
    {
        static void Main(string[] args)
        {
                Height height = new Height();

                BinaryTree tree = new BinaryTree();
                tree.root = new Node(1);
                tree.root.left = new Node(2);
                tree.root.right = new Node(3);
                tree.root.left.left = new Node(4);
                tree.root.left.right = new Node(5);
                tree.root.left.left.left = new Node(7);
                tree.root.right.left = new Node(10);
                if (tree.checkHeightBalance(tree.root, height))
                    Console.WriteLine("The tree is balanced");
                else
                    Console.WriteLine("The tree is not balanced");
                Console.Read();
            }

        }
    }
}
