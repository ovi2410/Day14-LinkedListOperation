﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LinkedList;

Console.WriteLine("----- Welcome TO LinkedList -----\n");

LinkedListOps list = new LinkedListOps();
list.Add(56);
list.Add(30);
list.Add(40);
list.Add(70);
list.Display();
Console.WriteLine("\n>> Current Size of Linked List :- " + list.Size());
list.DeleteElement(40);
list.Display();

