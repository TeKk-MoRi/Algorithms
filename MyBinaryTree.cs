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


    }
}