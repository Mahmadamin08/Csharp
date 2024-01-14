using BinarySearchTree;

BST bs = new BST();
bs.Insert(5);
bs.Insert(3);
bs.Insert(6);
bs.Insert(2);
bs.Insert(4);
bs.Insert(7);

bs.PreOrder(bs._root);
Console.WriteLine();
bs.InOrder(bs._root);
Console.WriteLine();
bs.PostOrder(bs._root);