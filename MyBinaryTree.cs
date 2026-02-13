using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

namespace YourNamespace;

public class MyBinaryTree
{
    private Node? _root;

    public bool Find(int value)
    {
        return _root?.Find(value) ?? false;
    }

    public int Min()
    {
        return _root.CalMin(_root);
    }

    public void TraversePreOrder()
    {
        _root.TraversePreOrder(_root);
    }
    public bool CheckEqual(MyBinaryTree other)
    {
        return _root.IsEqual(_root, other._root);
    }

    public bool CheckIfBinarySearchTree()
    {
        return _root.IsBinarySearchTree(_root ,  int.MinValue , int.MaxValue);
    }

    public int GetHeight()
    {
        if (_root is null)
            return -1;

        return _root.CalHeight(_root);
    }
    public void Insert(int value)
    {
        if (_root is null)
        {
            _root = new Node(value);
        }
        else
            _root.Insert(value);
    }
    private class Node
    {
        private readonly int _value;
        private Node? _leftChild;
        private Node? _rightChild;

        public Node(int value)
        {
            this._value = value;
        }


        public void Insert(int value)
        {

            var current = this;

            while (true)
            {

                if (current._value > value)
                {
                    if (current._leftChild is null)
                    {
                        current._leftChild = new Node(value);
                        return;
                    }

                    else
                        current = current._leftChild;
                }


                else
                {
                    if (current._rightChild is null)
                    {
                        current._rightChild = new Node(value);
                        return;
                    }

                    else
                        current = current._rightChild;
                }


            }

        }

        public bool Find(int value)
        {
            var current = this;
            while (current is not null)
            {
                if (current._value == value)
                    return true;

                else
                {
                    if (current._value > value)
                        current = current._leftChild;

                    else
                        current = current._rightChild;
                }
            }

            return false;
        }


        public void TraversePreOrder(Node root)
        {
            if (root is null)
                return;

            System.Console.WriteLine(root._value);
            TraversePreOrder(root._leftChild);
            TraversePreOrder(root._rightChild);

        }
        private bool IsLeaf(Node root)
        {
            return root._leftChild is null && root._rightChild is null;
        }
        public int CalMin(Node node)
        {
            if (IsLeaf(node))
                return node._value;

            var left = CalMin(node._leftChild);
            var right = CalMin(node._rightChild);

            var minOfLeftRight = Math.Min(left, right);
            var minOfAll = Math.Min(minOfLeftRight, node._value);

            return minOfAll;
        }

        public int CalHeight(Node node)
        {
            if (IsLeaf(node))
                return 0;
            return 1 + Math.Max(CalHeight(node._leftChild), CalHeight(node._rightChild));
        }

        public bool IsEqual(Node first, Node second)
        {
            if (first is null && second is null)
                return true;

            if (first is not null && second is not null)
                return first._value == second._value
                && IsEqual(first._leftChild, second._leftChild)
                && IsEqual(first._rightChild, second._rightChild);

            return false;
        }

        public bool IsBinarySearchTree(Node root, int minValue, int maxValue)
        {
            if (root is null)
                return true;

            if (root._value < minValue || root._value > maxValue)
                return false;

                return IsBinarySearchTree(root._leftChild , minValue , root._value - 1)
                && IsBinarySearchTree(root._rightChild , root._value + 1 , maxValue);

        }


    }
}