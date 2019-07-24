using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;      

namespace BinarySearchTreeAssignment
{
    public class BinaryTree
    {
        //member variables 
        public BinaryTree()
        {
            root = null;
            count = 0;

        }

        //constructor 

        //member methods 
        public void AddNode(int number)
        {
            if (root == null)
            {
                root = new Node(number);
            }
            else
            {
                root.InsertNode(ref root, number);
            }
            count++;
        }
            public bool search(Node node, int data)
            if (node == null)
            {
                return false;
            }
            if (node.number == data)
            {
                return true;
            }
            else if (node.number < data)
            {
                return search(node.leftBranch, data);
            }
            else if (node.number > data)
            {
                return search(node.rightBranch, data);
            }
            return false;
            public override string ToString()
            {
                string result = string.Empty;

                if (!IsEmpty)
                {
                    result = root.ToString();
                }

                return result;
            }
        
        }   
}

