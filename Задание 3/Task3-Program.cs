using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

class Program
{
    static void Main(string[] args)
    {
        var tree = new Tree<string>("Root");

        var child1 = tree.Root.AddChild("Child 1");
        var child2 = tree.Root.AddChild("Child 2");

        child1.AddChild("Grandchild 1.1");
        child1.AddChild("Grandchild 1.2");

        var grandchild2 = child2.AddChild("Grandchild 2.1");

        grandchild2.AddChild("Great-grandchild 2.1.1");

        Console.WriteLine("Tree structure:");
        tree.PrintTree();

        Console.WriteLine("\nChildren of Child 1:");
        child1.PrintAllChildren();
    }
}
