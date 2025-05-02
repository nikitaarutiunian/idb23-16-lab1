using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; }

        public Tree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }

        public void PrintTree()
        {
            Root.PrintAllChildren();
        }
    }
}
