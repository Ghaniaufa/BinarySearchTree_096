using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Node 
    {
        public string info;
        public Node leftchild;
        public Node rightchild;
        
        //Constructor for the node class

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }


    /* A node lass consits os three things, the information, reference to the
     * right child, and reference to the left child */

    class BinaryTree
    {
        public Node ROOT;
        public Node BinaryTree()
        {
            ROOT = null; /* Initializing ROOT to null */
        }
        public void insert(string element) /* Insert a node in th ebinary search tree */
        {
            Node tmp, parent = null, currentNode = null;
            Search(element, ref parent, ref currentNode);
            if (currentNode != null) /* Check if the node to be inserted already inserted or not */
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else /* If the spesiied node is not present */
            {
                tmp new Node(element, null, null);/* creates a Node*/
                if (parent == null)/* if the trees is epmty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) <0)
            }   
        }
    }
}
