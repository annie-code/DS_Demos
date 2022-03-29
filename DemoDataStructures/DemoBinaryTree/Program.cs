using System;

namespace DemoBinaryTree
{
    /* The Node class consists of three data members, the information, 
     * reference to the right child, and reference to the left child. */
    class Node
    {
        public int info;
        //public string info;
        public Node lchild;
        public Node rchild;
        public Node(int i, Node l, Node r) /* Constructor for the
        Node class */
        {
            info = i;
            lchild = l;
            rchild = r;
        }

        //public Node(string i, Node l, Node r) /* Constructor for the
        //Node class */
        //{
        //    info = i;
        //    lchild = l;
        //    rchild = r;
        //}
    }
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /* Initializing ROOT to null */
        }
        public void insert(int element)
       // public void insert(string element) /* Inserts a Node in the
       // Binary Search Tree */
        {
            Node tmp, parent = null, currentNode = null;
            find(element, ref parent, ref currentNode);
            if (currentNode != null) /* Checks if the node to be
            inserted is already present or not */
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else /* If the specified Node is not present */
            {
                tmp = new Node(element, null, null); /* Creates a
                Node */
                if (parent == null) /* If the tree is empty */
                    ROOT = tmp;
                else
                   // if (String.Compare(element, parent.info) < 0)
                   if (element<parent.info) 
                    parent.lchild = tmp;
                else
                    parent.rchild = tmp;
            }
        }
        public void find(int element, ref Node parent, ref Node
currentNode)
        //public void find(string element, ref Node parent, ref Node
        //currentNode)
        {
            /* This function finds a given element in the tree and
    		returns a variable containing the address of the 
    		corresponding node. It also returns a variable 
    		containing the address of the parent of the node. */

            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info !=
            element))
            {
                parent = currentNode;
                // if (String.Compare(element, currentNode.info) < 0)
                if (element< currentNode.info)
                    currentNode = currentNode.lchild;
                else
                    currentNode = currentNode.rchild;
            }
        }
        public void inorder(Node ptr) /* Performs the inorder
        traversal of the tree */
        {
            if (ptr != null)
            {
                inorder(ptr.lchild);
                Console.Write(ptr.info + "   ");
                inorder(ptr.rchild);
            }
        }
        //PreOrder
        public void preorder(Node ptr) /* Performs the preorder
        traversal of the tree */
        {
            if (ptr != null)
            {
                Console.Write(ptr.info + "   ");
                preorder(ptr.lchild);
                preorder(ptr.rchild);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree b = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implement insert operation");
                Console.WriteLine("2. Perform inorder traversal");
                Console.WriteLine("3. Perform Prorder traversal");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice (1-4): ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.Write("Enter a word: ");
                            //  string word = Console.ReadLine();
                           // b.insert(word);
                            int mark = int.Parse(Console.ReadLine());
                            b.insert(mark);


                        }
                        break;
                    case '2':
                        {
                            if (b.ROOT == null)
                            {
                                Console.WriteLine("Tree is empty");
                                Console.ReadLine();
                                return;
                            }

                            b.inorder(b.ROOT);
                        }
                        break;
                    case '3':
                        {
                            if (b.ROOT == null)
                            {
                                Console.WriteLine("Tree is empty");
                                Console.ReadLine();
                                return;
                            }

                            b.preorder(b.ROOT);
                        }
                        break;
                    case '4':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }

            }
        }
    }

}
   