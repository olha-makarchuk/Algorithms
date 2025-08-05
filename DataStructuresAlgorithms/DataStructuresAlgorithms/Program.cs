using DataStructuresAlgorithms.Model;

EasyStack<int> easyStack = new EasyStack<int>();
easyStack.Push(1);
easyStack.Push(2);
easyStack.Push(3);

var item3 = easyStack.Peek();

var item = easyStack.Pop();
var item2 = easyStack.Peek();

Console.WriteLine(item3);
Console.WriteLine(item);
Console.WriteLine(item2);
Console.ReadLine();

Stack<int> stack = new Stack<int>();    



LinkedStack<int> linkedList = new LinkedStack<int>();
linkedList.Push(10);
linkedList.Push(20);
linkedList.Push(30);
linkedList.Push(40);
linkedList.Push(50);

Console.WriteLine(linkedList.Peek()); // Output: 50
Console.WriteLine(linkedList.Pop());
Console.WriteLine(linkedList.Pop());
Console.WriteLine(linkedList.Peek());
Console.ReadLine();

var arrayStack = new ArrayStack<int>(5);
arrayStack.Push(100);
arrayStack.Push(200);
arrayStack.Push(300);
arrayStack.Push(400);
arrayStack.Push(500);

Console.WriteLine(arrayStack.Peek());
Console.WriteLine(arrayStack.Pop());
Console.WriteLine(arrayStack.Peek());
Console.WriteLine(arrayStack.Count);
