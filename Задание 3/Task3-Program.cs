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
        // Создаем дерево с корневым узлом "Root"
        var tree = new Tree<string>("Root");

        // Добавляем узлы первого уровня
        var child1 = tree.Root.AddChild("Child 1");
        var child2 = tree.Root.AddChild("Child 2");

        // Добавляем узлы второго уровня
        child1.AddChild("Grandchild 1.1");
        child1.AddChild("Grandchild 1.2");

        var grandchild2 = child2.AddChild("Grandchild 2.1");

        // Добавляем узлы третьего уровня
        grandchild2.AddChild("Great-grandchild 2.1.1");

        // Выводим все дерево
        Console.WriteLine("Tree structure:");
        tree.PrintTree();

        // Выводим только потомков конкретного узла
        Console.WriteLine("\nChildren of Child 1:");
        child1.PrintAllChildren();
    }
}
