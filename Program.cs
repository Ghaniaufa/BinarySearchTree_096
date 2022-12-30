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
        
    }
}
