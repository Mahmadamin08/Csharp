using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BST
    {
        public Node _root { get; set; }
        public BST()
        {
            _root = null;
        }

        public void Insert(int data)
        {
            Node node = new Node(data);
            if (_root == null)
            {
                _root = node;
                return;
            }
            Node p = _root;
            while (p != null)
            {
                if (node.data <= p.data)
                {
                    if (node.data <= p.data)
                    {
                        if (p.left == null)
                        {
                            p.left = node;
                            return;
                        }
                        p = p.left;
                    }
                }
                else
                {
                    if (node.data > p.data)
                    {
                        if (p.right == null)
                        {
                            p.right = node;
                            return;
                        }
                        p = p.right;
                    }
                }
            }
        }

        public bool Search(int data)
        {
            Node n = _root;
            while (n != null)
            {
                if (n.data == data)
                {
                    return true;
                }
                if (n.data < data)
                {
                    n = n.left;
                }
                else
                {
                    n = n.right;
                }
            }
            return false;
        }


        public void DeleteNode(int data)
        {
            Node n = _root;

            // Root
            if (n.data == data)
            {
                _root = ReArrenge(_root);
            }
            Node t = _root;
            Node ans = t;

            while (t != null)
            {
                if (t.data > data)
                {
                    if (t.left != null && t.left.data == data)
                    {
                        t.left = ReArrenge(t.left);
                        break;
                    }
                    else
                    {
                        t = t.left;
                    }
                }
                else
                {
                    if (t.right != null && t.right.data == data)
                    {
                        t.right = ReArrenge(t.right);
                        break;
                    }
                    else
                    {
                        t = t.right;
                    }
                }
            }
            _root = ans;
        }
        public Node ReArrenge(Node rt)
        {
            Node l = rt.left;
            Node r = rt.right;

            if (l == null) return r;
            if (r == null) return l;

            Node tempL = l;
            while (tempL.right != null)
            {
                tempL = tempL.right;
            }
            tempL.right = r;
            return l;
        }

        public void PreOrder(Node node)
        {
            if (node == null) return;
            if (node != null)
            {
                Console.Write(node.data + "  ");
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }
        public void InOrder(Node node)
        {
            if (node == null) return;
            Node temp = node;
            if (temp != null)
            {
                InOrder(node.left);
                Console.Write(node.data + "  ");
                InOrder(node.right);
            }
        }public void PostOrder(Node node)
        {
            if (node == null) return;
            Node temp = node;
            if (temp != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                Console.Write(node.data + "  ");
            }
        }
    }
}
