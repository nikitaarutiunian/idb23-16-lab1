using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();

        public TreeNode(T value)
        {
            Value = value;
        }

        public void PrintAllChildren(int level = 0)
        {
            Console.WriteLine($"{new string(' ', level * 2)}Node: {Value}");

            foreach (var child in Children)
            {
                child.PrintAllChildren(level + 1);
            }
        }

        public TreeNode<T> AddChild(T childValue)
        {
            var childNode = new TreeNode<T>(childValue);
            Children.Add(childNode);
            return childNode;
        }
    }
}